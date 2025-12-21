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
    public partial class DivisionEdit : Form
    {
        public DivisionEdit()
        {
            InitializeComponent();
        }

        public string EditDivisionName
        {
            get { return txtName.Text.Trim(); }
            set { txtName.Text = value; }
        }

        public string EditDivisionDirector
        {
            get { return txtDirector.Text.Trim(); }
            set { txtDirector.Text = value; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("не то");
                txtName.Focus();
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
