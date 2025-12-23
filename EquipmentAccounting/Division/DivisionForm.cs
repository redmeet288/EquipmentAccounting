using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EA_DAL.BaseGetConnect;
using EA_DAL.Models;





namespace EquipmentAccounting
{
    public partial class DivisionForm : Form
    {
        private BindingSource bindingSource;
        private readonly AllDbForItContext _db = new AllDbForItContext();
        private Repo<Division> _division;

        public DivisionForm()
        {
            InitializeComponent();

            _division = new Repo<Division>(_db);


            bindingSource = new BindingSource();

            dataGridView1.DataSource = bindingSource;

        }
        private void Division_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {

                dataGridView1.AutoGenerateColumns = false;
                bindingSource.DataSource = _division.GetAll().ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"всё было норм пока ты не загрузил " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var selected = (Division)dataGridView1.SelectedRows[0].DataBoundItem;



            var res = MessageBox.Show($"удалить {selected.Name}?", "удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                try
                {
                    _division.Delete(selected);
                    _division.Save();
                    LoadData();

                }
                catch (Exception r)
                {
                    MessageBox.Show("нет такого для удаления, другого сломаться не могло всё равботает " + r.Message);
                }
            }



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            var selected = (Division)dataGridView1.SelectedRows[0].DataBoundItem;


            var DeviEd = new DivisionEdit();

            DeviEd.EditDivisionName = selected.Name;
            DeviEd.EditDivisionDirector = selected.Director;

            DialogResult result = DeviEd.ShowDialog();



            if (result == DialogResult.OK)
            {
                try
                {
                    selected.Name = DeviEd.EditDivisionName.Trim();
                    selected.Director = DeviEd.EditDivisionDirector.Trim();

                    _division.Update(selected);
                    _division.Save();
                    LoadData();
                    MessageBox.Show("успех", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ты виноват у меня всё работает" + ex.Message);
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var deviEd = new DivisionEdit();
            DialogResult result = deviEd.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    var newDivision = new Division
                    {
                        Name = deviEd.EditDivisionName.Trim(),
                        Director = deviEd.EditDivisionDirector?.Trim()
                    };

                    _division.Add(newDivision);  
                    _division.Save();  

                    LoadData();
                    MessageBox.Show($"Добавил {deviEd.EditDivisionName}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ты опять виноват, у меня всё работает" + ex.Message);
                }
            }

        }
    }
}
