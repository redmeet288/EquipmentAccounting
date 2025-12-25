using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EquipmentAccounting.SoftwareLicen
{
    partial class SoftwareLinsEdit
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panelFields = new Panel();
            lblSoftwareName = new Label();
            txtSoftwareName = new TextBox();
            lblManufacturer = new Label();
            txtManufacturer = new TextBox();
            lblLicenseKey = new Label();
            txtLicenseKey = new TextBox();
            lblExpiryDate = new Label();
            dtpExpiryDate = new DateTimePicker();
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
            tableLayoutPanel1.Size = new Size(450, 300);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelFields
            // 
            panelFields.Controls.Add(lblSoftwareName);
            panelFields.Controls.Add(txtSoftwareName);
            panelFields.Controls.Add(lblManufacturer);
            panelFields.Controls.Add(txtManufacturer);
            panelFields.Controls.Add(lblLicenseKey);
            panelFields.Controls.Add(txtLicenseKey);
            panelFields.Controls.Add(lblExpiryDate);
            panelFields.Controls.Add(dtpExpiryDate);
            panelFields.Dock = DockStyle.Fill;
            panelFields.Location = new Point(3, 3);
            panelFields.Name = "panelFields";
            panelFields.Padding = new Padding(15);
            panelFields.Size = new Size(444, 244);
            panelFields.TabIndex = 0;
            // 
            // lblSoftwareName
            // 
            lblSoftwareName.AutoSize = true;
            lblSoftwareName.Location = new Point(12, 20);
            lblSoftwareName.Name = "lblSoftwareName";
            lblSoftwareName.Size = new Size(83, 15);
            lblSoftwareName.TabIndex = 0;
            lblSoftwareName.Text = "Название ПО:";
            // 
            // txtSoftwareName
            // 
            txtSoftwareName.Location = new Point(15, 38);
            txtSoftwareName.Name = "txtSoftwareName";
            txtSoftwareName.Size = new Size(415, 23);
            txtSoftwareName.TabIndex = 1;
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(12, 74);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(95, 15);
            lblManufacturer.TabIndex = 2;
            lblManufacturer.Text = "Производитель:";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(15, 92);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(415, 23);
            txtManufacturer.TabIndex = 3;
            // 
            // lblLicenseKey
            // 
            lblLicenseKey.AutoSize = true;
            lblLicenseKey.Location = new Point(12, 128);
            lblLicenseKey.Name = "lblLicenseKey";
            lblLicenseKey.Size = new Size(97, 15);
            lblLicenseKey.TabIndex = 4;
            lblLicenseKey.Text = "Ключ лицензии:";
            // 
            // txtLicenseKey
            // 
            txtLicenseKey.Location = new Point(15, 146);
            txtLicenseKey.Name = "txtLicenseKey";
            txtLicenseKey.Size = new Size(415, 23);
            txtLicenseKey.TabIndex = 5;
            // 
            // lblExpiryDate
            // 
            lblExpiryDate.AutoSize = true;
            lblExpiryDate.Location = new Point(12, 182);
            lblExpiryDate.Name = "lblExpiryDate";
            lblExpiryDate.Size = new Size(98, 15);
            lblExpiryDate.TabIndex = 6;
            lblExpiryDate.Text = "Дата окончания:";
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.Format = DateTimePickerFormat.Short;
            dtpExpiryDate.Location = new Point(15, 200);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(415, 23);
            dtpExpiryDate.TabIndex = 7;
            dtpExpiryDate.Value = new DateTime(2026, 12, 25, 0, 0, 0, 0);
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnOK);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 253);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(444, 44);
            panelButtons.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(350, 7);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(90, 30);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(254, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 30);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SoftwareLinsEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 300);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SoftwareLinsEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редактирование лицензии ПО";
            Load += SoftwareLicenseEdit_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panelFields.ResumeLayout(false);
            panelFields.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelButtons;
        private Button btnOK;
        private Button btnCancel;
        private Panel panelFields;
        private Label lblSoftwareName;
        private TextBox txtSoftwareName;
        private Label lblManufacturer;
        private TextBox txtManufacturer;
        private Label lblLicenseKey;
        private TextBox txtLicenseKey;
        private Label lblExpiryDate;
        private DateTimePicker dtpExpiryDate;
    }
}
