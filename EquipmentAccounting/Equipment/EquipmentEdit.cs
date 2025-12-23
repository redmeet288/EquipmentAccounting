using System;
using System.Drawing;
using System.Windows.Forms;

namespace EquipmentAccounting.Equipment
{
    public partial class EquipmentEdit : Form
    {
        public EquipmentEdit()
        {
            InitializeComponent();
        }

        public string EditInventoryNumber
        {
            get { return txtInventoryNumber.Text.Trim(); }
            set { txtInventoryNumber.Text = value ?? ""; }
        }

        public string EditName
        {
            get { return txtName.Text.Trim(); }
            set { txtName.Text = value ?? ""; }
        }

        public string EditTypeId
        {
            get { return txtTypeId.Text.Trim(); }
            set { txtTypeId.Text = value ?? ""; }
        }

        public string EditSerialNumber
        {
            get { return txtSerialNumber.Text.Trim(); }
            set { txtSerialNumber.Text = value ?? ""; }
        }

        public string EditResponsibleId
        {
            get { return txtResponsibleId.Text.Trim(); }
            set { txtResponsibleId.Text = value ?? ""; }
        }

        public DateTime EditRegistrationDate
        {
            get { return dtpRegistrationDate.Value; }
            set
            {
                dtpRegistrationDate.Value = (value.Year < 1900) ? DateTime.Now.Date : value;
            }
        }

        public string EditStatus
        {
            get { return cmbStatus.SelectedItem?.ToString() ?? ""; }
            set
            {
                if (cmbStatus.Items.Contains(value))
                    cmbStatus.SelectedItem = value;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInventoryNumber.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Заполните обязательные поля!");
                txtInventoryNumber.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
