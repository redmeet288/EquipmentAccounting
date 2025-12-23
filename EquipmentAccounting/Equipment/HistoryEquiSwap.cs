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

namespace EquipmentAccounting.Equipment
{
    public partial class HistoryEquiSwap : Form

    {
        private BindingSource bindingSource;
        private readonly AllDbForItContext _db = new AllDbForItContext();
        private Repo<TransferHistory> _history;
        public HistoryEquiSwap()
        {
            InitializeComponent();
            _history = new Repo<TransferHistory>(_db);
            bindingSource = new BindingSource();
            
            dataGridView1.DataSource = bindingSource;


            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var select = (TransferHistory)dataGridView1.SelectedRows[0].DataBoundItem;

                var res = MessageBox.Show("удалить запись под id " + select.Id + "?", "удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    _history.Delete(select);
                    _history.Save();
                    LoadHistory();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления: " + ex.Message);
            }


        }

        private void TransferHistoryForm_Load(object sender, EventArgs e)
        {
            
            LoadHistory();
        }

        private void LoadHistory()
        {

            try
            {
                dataGridView1.AutoGenerateColumns = false;
                bindingSource.DataSource = _history.GetAll().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }

        }
    }
}
