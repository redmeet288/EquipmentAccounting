using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EquipmentAccounting
{
    public partial class StaffEdit : Form
    {
        public StaffEdit()
        {
            InitializeComponent();
        }
        public string EditStaffFio
        {
            get { return txtFIO.Text.Trim(); }
            set { txtFIO.Text = value; }
        }

        public string EditStaffPost
        {
            get { return txtPosition.Text.Trim(); }
            set { txtPosition.Text = value; }
        }

        public string EditStaffDivisionId
        {
            get { return txtDivisionId.Text.Trim(); }
            set { txtDivisionId.Text = value; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFIO.Text))
            {
                MessageBox.Show("не то");
                txtFIO.Focus();

                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void EquiEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
