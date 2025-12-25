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

namespace EquipmentAccounting.SoftwareLicen
{
    public partial class SoftwareLinsForm : Form
    {
        private BindingSource bindingSource;
        private readonly AllDbForItContext _db = new AllDbForItContext();
        private Repo<SoftwareLicense> _licenses;
        public SoftwareLinsForm()
        {
            InitializeComponent();
            _licenses = new Repo<SoftwareLicense>(_db);
            bindingSource = new BindingSource();
            dataGridView1.DataSource = bindingSource;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var licenseEdit = new SoftwareLinsEdit();
            if (licenseEdit.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var newLicense = new SoftwareLicense
                    {
                        SoftwareName = licenseEdit.EditSoftwareName,
                        Vendor = licenseEdit.EditVendor,
                        LicenseKey = licenseEdit.EditLicenseKey,
                        ExpirationDate = licenseEdit.EditExpiryDate
                    };
                    _licenses.Add(newLicense);
                    _licenses.Save();
                    LoadLicenses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавления: " + ex.Message);
                }
            }
        }
        private void SoftwareLicensesForm_Load(object sender, EventArgs e)
        {
            LoadLicenses();
        }
        private void LoadLicenses()
        {
            try
            {
                bindingSource.DataSource = null;
                dataGridView1.AutoGenerateColumns = false;
                bindingSource.DataSource = _licenses.GetAll().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите лицензию!");
                return;
            }

            var selected = (SoftwareLicense)dataGridView1.SelectedRows[0].DataBoundItem;
            var licenseEdit = new SoftwareLinsEdit();

            licenseEdit.EditSoftwareName = selected.SoftwareName;
            licenseEdit.EditVendor = selected.Vendor;
            licenseEdit.EditLicenseKey = selected.LicenseKey;
            licenseEdit.EditExpiryDate = selected.ExpirationDate;

            if (licenseEdit.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    selected.SoftwareName = licenseEdit.EditSoftwareName;
                    selected.Vendor = licenseEdit.EditVendor;
                    selected.LicenseKey = licenseEdit.EditLicenseKey;
                    selected.ExpirationDate = licenseEdit.EditExpiryDate;

                    _licenses.Update(selected);
                    _licenses.Save();
                    LoadLicenses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка изменения: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = (SoftwareLicense)dataGridView1.SelectedRows[0].DataBoundItem;

            var res = MessageBox.Show($"Удалить лицензию?\n{selected.SoftwareName}\n{selected.Vendor}",
            "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (res == DialogResult.Yes)
            {
                try
                {
                    _licenses.Delete(selected);
                    _licenses.Save();

                    LoadLicenses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("hsdfuihgusdif: " + ex.Message);
                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLicenses();
        }
    }
}
