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
    public partial class EquipmentForm : Form
    {
        private BindingSource bindingSource;
        private readonly AllDbForItContext _db = new AllDbForItContext();
        private Repo<EA_DAL.Models.Equipment> _equipment;
        private Repo<EA_DAL.Models.TransferHistory> _history;
        public EquipmentForm()
        {
            InitializeComponent();
            _equipment = new Repo<EA_DAL.Models.Equipment>(_db);
            _history = new Repo<TransferHistory>(_db);
            bindingSource = new BindingSource();
            dataGridView1.DataSource = bindingSource;
        }
        private void EquipmentForm_Load(object sender, EventArgs e)
        {
            LoadEquipment();
        }

        private void LoadEquipment()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                bindingSource.DataSource = null;
                bindingSource.DataSource = _equipment.GetAll().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var Dev = new EquipmentEdit();
            DialogResult res = Dev.ShowDialog();

            if (res == DialogResult.OK)
            {
                try
                {
                    var equipment = new EA_DAL.Models.Equipment
                    {
                        InventoryNumber = Dev.EditInventoryNumber,
                        Name = Dev.EditName,
                        TypeId = Convert.ToInt32(Dev.EditTypeId),
                        SerialNumber = Dev.EditSerialNumber,
                        ResponsibleStaffId = Convert.ToInt32(Dev.EditResponsibleId),
                        RegistrationDate = Dev.EditRegistrationDate,
                        Status = Dev.EditStatus
                    };
                    _equipment.Add(equipment);
                    _equipment.Save();
                    LoadEquipment();
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



            var selected = (EA_DAL.Models.Equipment)dataGridView1.SelectedRows[0].DataBoundItem;


            string oldStaffIdStr = selected.ResponsibleStaffId?.ToString() ?? "0";
            int oldStaffId = int.TryParse(oldStaffIdStr, out int parsedOld) ? parsedOld : 0;

            var dev = new EquipmentEdit();




            dev.EditInventoryNumber = selected.InventoryNumber;
            dev.EditName = selected.Name;
            dev.EditTypeId = selected.TypeId.ToString();
            dev.EditSerialNumber = selected.SerialNumber ?? "";
            dev.EditResponsibleId = oldStaffIdStr;
            dev.EditRegistrationDate = selected.RegistrationDate;
            dev.EditStatus = selected.Status ?? "";

            



            var res = dev.ShowDialog();

            if (res == DialogResult.OK)
            {
                try
                {
                    int newStaffId = int.TryParse(dev.EditResponsibleId, out int parsedNew) ? parsedNew : 0;

                    selected.InventoryNumber = dev.EditInventoryNumber;
                    selected.Name = dev.EditName;
                    selected.TypeId = Convert.ToInt32(dev.EditTypeId);
                    selected.SerialNumber = dev.EditSerialNumber;
                    selected.ResponsibleStaffId = Convert.ToInt32(dev.EditResponsibleId);
                    selected.RegistrationDate = dev.EditRegistrationDate;
                    selected.Status = dev.EditStatus;

                    if (oldStaffId != newStaffId && newStaffId > 0)
                    {
                        var d = new TransferHistory
                        {
                            Equipment = selected,
                            TransferDate = DateTime.Now,
                            OldEmployeeId =  oldStaffId > 0 ? oldStaffId : null,
                            NewEmployeeId = Convert.ToInt32(selected.ResponsibleStaffId)

                        };
                        _history.Add(d);
                        _history.Save();

                    }

                    _equipment.Update(selected);
                    _equipment.Save();
                    LoadEquipment();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ты виноват у меня всё работает" + ex.Message);
                }


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = (EA_DAL.Models.Equipment)dataGridView1.SelectedRows[0].DataBoundItem;

            var res = MessageBox.Show($"удалить {selected.Name}?", "удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                try
                {
                    _equipment.Delete(selected);
                    _equipment.Save();
                    LoadEquipment();

                }
                catch (Exception r)
                {
                    MessageBox.Show("нет такого для удаления, другого сломаться не могло всё равботает " + r.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEquipment();
        }
    }
}
