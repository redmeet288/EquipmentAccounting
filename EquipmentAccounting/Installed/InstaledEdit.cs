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
    public partial class InstaledEdit : Form
    {
        public InstaledEdit()
        {
            InitializeComponent();
        }

        private void lblSoftwareLicenseId_Click(object sender, EventArgs e)
        {

        }

        public string EditEquipmentId
        {
            get { return txtEquipmentId.Text.Trim(); }
            set { txtEquipmentId.Text = value ?? ""; }
        }

        public string EditSoftwareLicenseId
        {
            get { return txtSoftwareLicenseId.Text.Trim(); }
            set { txtSoftwareLicenseId.Text = value ?? ""; }
        }

        public DateTime EditInstallationDate
        {
            get { return dtpInstallationDate.Value; }
            set { dtpInstallationDate.Value = value; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEquipmentId.Text) ||
                string.IsNullOrWhiteSpace(txtSoftwareLicenseId.Text))
            {
                MessageBox.Show("Заполните ID оборудования и лицензии!");
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
