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
    public partial class Division : Form
    {
        private BindingSource bindingSource;
        public Division()
        {
            InitializeComponent();
        }
        private void Division_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string sql = "SELECT * FROM Divisions ORDER BY Name";
                DataTable dt = Connect.ExecuteSelect(sql);

                bindingSource.DataSource = dt;
                lblCount.Text = $"Записей: {dt.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"всё было норм пока ты не загрузил " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingSource.Current;
            int ID = Convert.ToInt32(row["Id"]);
            string name = row["Name"].ToString();

            var res = MessageBox.Show($"удалить {name}?", "удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                try
                {
                    int dd = Connect.ExecuteSql($"DELETE FROM Divisions WHERE Id = {ID}");

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
            DataRowView row = (DataRowView)bindingSource.Current;
            int ID = Convert.ToInt32(row["Id"]);
            var DeviEd = new DivisionEdit();
            DeviEd.DivisionName = row["Name"].ToString();
            DeviEd.DivisionDirector = row["Director"]?.ToString();


            if (DeviEd.DialogResult == DialogResult.OK)
            {
                try
                {
                    Connect.ExecuteSql($"UPDATE Divisions SET Name = '{DeviEd.DivisionName}', Director = '{DeviEd.DivisionDirector}' WHERE Id = {ID}");
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
            var DeviEd = new DivisionEdit();
            if (DeviEd.DialogResult == DialogResult.OK)
            {
                try
                {
                    Connect.ExecuteSql($"INSERT INTO Devisions (Name, Director) VALIUES ({DeviEd.Name},{DeviEd.Director})");
                    LoadData();
                    MessageBox.Show($"Добавили {DeviEd.Name}");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ты опять виноват, у меня всё работает" + ex.Message);
                }
            }

        }
    }
}
