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

namespace EquipmentAccounting
{
    public partial class TypesOfEquipmentForm : Form
    {
        private BindingSource bindingSource;
        private readonly AllDbForItContext _db = new AllDbForItContext();
        private Repo<TypesOfEquipment> _types;
        public TypesOfEquipmentForm()
        {
            InitializeComponent();
            _types = new Repo<TypesOfEquipment>(_db);

            bindingSource = new BindingSource();
            dataGridView1.DataSource = bindingSource;
        }

        private void TypesOfEquipmentForm_Load(object sender, EventArgs e)
        {
            LoadTypes();
        }

        private void LoadTypes()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                bindingSource.DataSource = _types.GetAll().ToList();
                //MessageBox.Show(_types.GetAll().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки типов оборудования: " + ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var Dev = new TypeEdit();

            DialogResult res = Dev.ShowDialog();
            if (res == DialogResult.OK)
            {
                try
                {
                    var d = new TypesOfEquipment
                    {
                        Name = Dev.EditTypeName
                    };
                    _types.Add(d);
                    _types.Save();
                    LoadTypes();

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
            var selected = (TypesOfEquipment)dataGridView1.SelectedRows[0].DataBoundItem;
            var Dev = new TypeEdit();
            Dev.EditTypeName = selected.Name;

            DialogResult res = Dev.ShowDialog();

            if (res == DialogResult.OK)
            {
                try
                {
                    selected.Name = Dev.EditTypeName;

                    _types.Update(selected);
                    _types.Save();

                    LoadTypes();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ты виноват у меня всё работает" + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = (TypesOfEquipment)dataGridView1.SelectedRows[0].DataBoundItem;

            var res = MessageBox.Show($"удалить {selected.Name}?", "удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                try
                {
                    _types.Delete(selected);
                    _types.Save();
                    LoadTypes();

                }
                catch (Exception r)
                {
                    MessageBox.Show("нет такого для удаления, другого сломаться не могло всё равботает " + r.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTypes();
        }
    }
}
