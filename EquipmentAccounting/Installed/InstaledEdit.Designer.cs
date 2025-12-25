using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EquipmentAccounting.Installed
{
    partial class InstaledEdit
    {
        // ... стандартный Dispose ...

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panelFields = new Panel();
            lblEquipmentId = new Label();
            txtEquipmentId = new TextBox();
            lblSoftwareLicenseId = new Label();
            txtSoftwareLicenseId = new TextBox();
            lblInstallationDate = new Label();
            dtpInstallationDate = new DateTimePicker();
            panelButtons = new Panel();
            btnOK = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            panelFields.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelFields, 0, 0);
            tableLayoutPanel1.Controls.Add(panelButtons, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(450, 250);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelFields
            // 
            panelFields.Controls.Add(lblEquipmentId);
            panelFields.Controls.Add(txtEquipmentId);
            panelFields.Controls.Add(lblSoftwareLicenseId);
            panelFields.Controls.Add(txtSoftwareLicenseId);
            panelFields.Controls.Add(lblInstallationDate);
            panelFields.Controls.Add(dtpInstallationDate);
            panelFields.Dock = DockStyle.Fill;
            panelFields.Location = new Point(3, 3);
            panelFields.Name = "panelFields";
            panelFields.Padding = new Padding(15);
            panelFields.Size = new Size(444, 194);
            panelFields.TabIndex = 0;
            // 
            // lblEquipmentId
            // 
            lblEquipmentId.AutoSize = true;
            lblEquipmentId.Location = new Point(18, 20);
            lblEquipmentId.Name = "lblEquipmentId";
            lblEquipmentId.Size = new Size(105, 15);
            lblEquipmentId.TabIndex = 0;
            lblEquipmentId.Text = "ID Оборудования:";
            // 
            // txtEquipmentId
            // 
            txtEquipmentId.Location = new Point(15, 38);
            txtEquipmentId.Name = "txtEquipmentId";
            txtEquipmentId.Size = new Size(415, 23);
            txtEquipmentId.TabIndex = 1;
            // 
            // lblSoftwareLicenseId
            // 
            lblSoftwareLicenseId.AutoSize = true;
            lblSoftwareLicenseId.Location = new Point(18, 74);
            lblSoftwareLicenseId.Name = "lblSoftwareLicenseId";
            lblSoftwareLicenseId.Size = new Size(99, 15);
            lblSoftwareLicenseId.TabIndex = 2;
            lblSoftwareLicenseId.Text = "ID Лицензии ПО:";
            lblSoftwareLicenseId.Click += lblSoftwareLicenseId_Click;
            // 
            // txtSoftwareLicenseId
            // 
            txtSoftwareLicenseId.Location = new Point(15, 92);
            txtSoftwareLicenseId.Name = "txtSoftwareLicenseId";
            txtSoftwareLicenseId.Size = new Size(415, 23);
            txtSoftwareLicenseId.TabIndex = 3;
            // 
            // lblInstallationDate
            // 
            lblInstallationDate.AutoSize = true;
            lblInstallationDate.Location = new Point(18, 128);
            lblInstallationDate.Name = "lblInstallationDate";
            lblInstallationDate.Size = new Size(94, 15);
            lblInstallationDate.TabIndex = 4;
            lblInstallationDate.Text = "Дата установки:";
            // 
            // dtpInstallationDate
            // 
            dtpInstallationDate.Format = DateTimePickerFormat.Short;
            dtpInstallationDate.Location = new Point(15, 146);
            dtpInstallationDate.Name = "dtpInstallationDate";
            dtpInstallationDate.Size = new Size(415, 23);
            dtpInstallationDate.TabIndex = 5;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnOK);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 203);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(444, 44);
            panelButtons.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(340, 5);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(90, 30);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(244, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 30);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            // 
            // InstaledEdit
            // 
            ClientSize = new Size(450, 250);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InstaledEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Установка ПО";
            tableLayoutPanel1.ResumeLayout(false);
            panelFields.ResumeLayout(false);
            panelFields.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelButtons;
        private Button btnOK;
        private Button btnCancel;
        private Panel panelFields;
        private Label lblEquipmentId;
        private TextBox txtEquipmentId;
        private Label lblSoftwareLicenseId;
        private TextBox txtSoftwareLicenseId;
        private Label lblInstallationDate;
        private DateTimePicker dtpInstallationDate;
    }
}
