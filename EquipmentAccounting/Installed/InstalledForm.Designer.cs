using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EquipmentAccounting.Installed
{
    partial class InstalledForm
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
            panel1 = new Panel();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            ColumnEquipmentId = new DataGridViewTextBoxColumn();
            ColumnSoftwareLicenseId = new DataGridViewTextBoxColumn();
            ColumnInstallationDate = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(1000, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 44);
            panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Location = new Point(898, 7);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 30);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Обновить";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(200, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(104, 7);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 30);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(8, 7);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(994, 514);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnEquipmentId, ColumnSoftwareLicenseId, ColumnInstallationDate });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(994, 514);
            dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 573);
            panel3.Name = "panel3";
            panel3.Size = new Size(994, 24);
            panel3.TabIndex = 2;
            // 
            // ColumnEquipmentId
            // 
            ColumnEquipmentId.DataPropertyName = "EquipmentId";
            ColumnEquipmentId.FillWeight = 30F;
            ColumnEquipmentId.HeaderText = "ID Оборудования";
            ColumnEquipmentId.Name = "ColumnEquipmentId";
            ColumnEquipmentId.ReadOnly = true;
            // 
            // ColumnSoftwareLicenseId
            // 
            ColumnSoftwareLicenseId.DataPropertyName = "LicenseId";
            ColumnSoftwareLicenseId.FillWeight = 30F;
            ColumnSoftwareLicenseId.HeaderText = "ID Лицензии";
            ColumnSoftwareLicenseId.Name = "ColumnSoftwareLicenseId";
            ColumnSoftwareLicenseId.ReadOnly = true;
            // 
            // ColumnInstallationDate
            // 
            ColumnInstallationDate.DataPropertyName = "InstallationDate";
            ColumnInstallationDate.FillWeight = 40F;
            ColumnInstallationDate.HeaderText = "Дата установки";
            ColumnInstallationDate.Name = "ColumnInstallationDate";
            ColumnInstallationDate.ReadOnly = true;
            // 
            // InstalledForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(tableLayoutPanel1);
            Name = "InstalledForm";
            Text = "Установленное ПО";
            Load += InstalledSoftwareForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private DataGridViewTextBoxColumn ColumnEquipmentId;
        private DataGridViewTextBoxColumn ColumnSoftwareLicenseId;
        private DataGridViewTextBoxColumn ColumnInstallationDate;
    }
}
