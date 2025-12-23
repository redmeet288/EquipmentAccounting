using System;
using System.Drawing;
using System.Windows.Forms;

namespace EquipmentAccounting.Equipment
{
    public partial class EquipmentEdit : Form
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

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label7 = new Label();
            cmbStatus = new ComboBox();
            label6 = new Label();
            dtpRegistrationDate = new DateTimePicker();
            label5 = new Label();
            txtResponsibleId = new TextBox();
            label4 = new Label();
            txtSerialNumber = new TextBox();
            label3 = new Label();
            txtTypeId = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtInventoryNumber = new TextBox();
            panel2 = new Panel();
            btnCancel = new Button();
            btnOK = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(436, 325);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtpRegistrationDate);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtResponsibleId);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSerialNumber);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTypeId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtInventoryNumber);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 269);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 233);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 12;
            label7.Text = "Статус:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "В работе", "На списании", "В ремонте" });
            cmbStatus.Location = new Point(130, 230);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(250, 23);
            cmbStatus.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 198);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 10;
            label6.Text = "Дата учета:";
            // 
            // dtpRegistrationDate
            // 
            dtpRegistrationDate.Location = new Point(130, 195);
            dtpRegistrationDate.Name = "dtpRegistrationDate";
            dtpRegistrationDate.Size = new Size(250, 23);
            dtpRegistrationDate.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 163);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 8;
            label5.Text = "ID Сотрудника:";
            // 
            // txtResponsibleId
            // 
            txtResponsibleId.Location = new Point(130, 160);
            txtResponsibleId.Name = "txtResponsibleId";
            txtResponsibleId.Size = new Size(250, 23);
            txtResponsibleId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 128);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 6;
            label4.Text = "Серийный №:";
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new Point(130, 125);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(250, 23);
            txtSerialNumber.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 93);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "ID Типа:";
            // 
            // txtTypeId
            // 
            txtTypeId.Location = new Point(130, 90);
            txtTypeId.Name = "txtTypeId";
            txtTypeId.Size = new Size(250, 23);
            txtTypeId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 58);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Название:*";
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Инв. номер:*";
            // 
            // txtInventoryNumber
            // 
            txtInventoryNumber.Location = new Point(130, 20);
            txtInventoryNumber.Name = "txtInventoryNumber";
            txtInventoryNumber.Size = new Size(250, 23);
            txtInventoryNumber.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnOK);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 278);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 44);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(343, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOK.Location = new Point(262, 10);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 30);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // EquipmentEdit
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(436, 325);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EquipmentEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление оборудования";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }


        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label7;
        private ComboBox cmbStatus;
        private Label label6;
        private DateTimePicker dtpRegistrationDate;
        private Label label5;
        private TextBox txtResponsibleId;
        private Label label4;
        private TextBox txtSerialNumber;
        private Label label3;
        private TextBox txtTypeId;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private TextBox txtInventoryNumber;
        private Panel panel2;
        private Button btnCancel;
        private Button btnOK;
    }
}
