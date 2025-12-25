using EA_DAL.BaseGetConnect;
using EA_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentAccounting.Installed
{
    public partial class InstalledForm : Form
    {
        private BindingSource bindingSource;
        private readonly AllDbForItContext _db = new AllDbForItContext();
        private Repo<InstalledSoftware> _installed;
        public InstalledForm()
        {
            InitializeComponent();
            _installed = new Repo<InstalledSoftware>(_db);
            bindingSource = new BindingSource();
            dataGridView1.DataSource = bindingSource;
        }
        private void InstalledSoftwareForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                bindingSource.DataSource = null;
                dataGridView1.AutoGenerateColumns = false;
                bindingSource.DataSource = _installed.GetAll().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ошибка загрузки: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editForm = new InstaledEdit();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var newItem = new InstalledSoftware
                    {
                        EquipmentId = int.Parse(editForm.EditEquipmentId),
                        LicenseId = int.Parse(editForm.EditSoftwareLicenseId),
                        InstallationDate = editForm.EditInstallationDate
                    };
                    _installed.Add(newItem);
                    _installed.Save();
                    LoadData();
                }
                catch (Exception ex)
                {
                    string errorDetails = ex.Message;
                    var inner = ex.InnerException;
                    while (inner != null)
                    {
                        errorDetails += $"\nINNER: {inner.Message}";
                        inner = inner.InnerException;
                    }
                    MessageBox.Show($"Полная ошибка:\n{errorDetails}");
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("выберите запись!");
                return;
            }

            var selected = (InstalledSoftware)dataGridView1.SelectedRows[0].DataBoundItem;
            var editForm = new InstaledEdit();

            editForm.EditEquipmentId = selected.EquipmentId.ToString();
            editForm.EditSoftwareLicenseId = selected.LicenseId.ToString();
            editForm.EditInstallationDate = selected.InstallationDate;

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    selected.EquipmentId = int.Parse(editForm.EditEquipmentId);
                    selected.LicenseId = int.Parse(editForm.EditSoftwareLicenseId);
                    selected.InstallationDate = editForm.EditInstallationDate;

                    _installed.Update(selected);
                    _installed.Save();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ошибка изменения: " + ex.Message);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("выберите запись!");
                return;
            }

            var selected = (InstalledSoftware)dataGridView1.SelectedRows[0].DataBoundItem;
            var res = MessageBox.Show($"удалить?\nоборудование ID: {selected.EquipmentId} ID: {selected.LicenseId}",
                "удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                try
                {
                    _installed.Delete(selected);
                    _installed.Save();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ошибка удаления: " + ex.Message);
                }
            }
        }
    }
}
