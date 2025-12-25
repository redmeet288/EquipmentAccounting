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
    public partial class SoftwareLinsEdit : Form
    {
        public SoftwareLinsEdit()
        {
            InitializeComponent();
        }

        public string EditSoftwareName
        {
            get { return txtSoftwareName.Text.Trim(); }
            set { txtSoftwareName.Text = value ?? ""; }
        }

        public string EditVendor
        {
            get { return txtManufacturer.Text.Trim(); }
            set { txtManufacturer.Text = value ?? ""; }
        }

        public string EditLicenseKey
        {
            get { return txtLicenseKey.Text.Trim(); }
            set { txtLicenseKey.Text = value ?? ""; }
        }

        public DateTime EditExpiryDate
        {
            get { return dtpExpiryDate.Value; }
            set { dtpExpiryDate.Value = value; }
        }




        private void SoftwareLicenseEdit_Load(object sender, EventArgs e)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoftwareName.Text))
            {
                MessageBox.Show("Заполните название ПО!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoftwareName.Focus();
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; Close();
        }
    }
}
