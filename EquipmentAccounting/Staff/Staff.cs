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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace EquipmentAccounting
{
    public partial class Staff : Form
    {
        private BindingSource bindingSource;
        private readonly AllDbForItContext _db = new AllDbForItContext();
        private Repo<EA_DAL.Models.Staff> _staff;
        public Staff()
        {
            InitializeComponent();
            _staff = new Repo<EA_DAL.Models.Staff>(_db);

            bindingSource = new BindingSource();
            dataGridView1.DataSource = bindingSource;

        }


        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                bindingSource.DataSource = _staff.GetAll().ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"всё было норм пока ты не загрузил " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var Dev = new StaffEdit();

            DialogResult res = Dev.ShowDialog();

            if (res == DialogResult.OK)
            {
                try
                {
                    int IdDivision2 = Convert.ToInt32(Dev.EditStaffDivisionId);

                    if (!_db.Divisions.Any(d => d.Id == IdDivision2))
                    {
                        MessageBox.Show("ID Подразделения не существует!");
                        return;
                    }
                    var d = new EA_DAL.Models.Staff
                    {
                        Fio = Dev.EditStaffFio,
                        Post = Dev.EditStaffPost,
                        IdDivision = IdDivision2
                    };
                    MessageBox.Show($"Id = {d.Id}");


                    _staff.Add(d);
                    _staff.Save();
                    MessageBox.Show($"Новый Id = {_staff.GetAll().Last().Id}");

                    LoadEmployees();

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
            
            var selected = (EA_DAL.Models.Staff)dataGridView1.SelectedRows[0].DataBoundItem;


            var Dev = new StaffEdit();

            Dev.EditStaffFio = selected.Fio;
            Dev.EditStaffPost = selected.Post;
            Dev.EditStaffDivisionId = selected.IdDivision.ToString();

            DialogResult res = Dev.ShowDialog();

            if(res == DialogResult.OK)
            {
                try
                {
                    selected.Fio = Dev.EditStaffFio;
                    selected.Post = Dev.EditStaffPost;
                    selected.IdDivision = Convert.ToInt32(Dev.EditStaffDivisionId);

                    _staff.Update(selected);
                    _staff.Save();

                    LoadEmployees();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ты виноват у меня всё работает" + ex.Message);
                }
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = (EA_DAL.Models.Staff)dataGridView1.SelectedRows[0].DataBoundItem;

            var res = MessageBox.Show($"удалить {selected.Fio}?", "удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                try
                {
                    _staff.Delete(selected);
                    _staff.Save();
                    LoadEmployees();

                }
                catch (Exception r)
                {
                    MessageBox.Show("нет такого для удаления, другого сломаться не могло всё равботает " + r.Message);
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }
    }
}
