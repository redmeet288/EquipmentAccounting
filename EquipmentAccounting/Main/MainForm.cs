using EA_DAL.Models;
using EquipmentAccounting.Equipment;
using EquipmentAccounting.Installed;
using EquipmentAccounting.SoftwareLicen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text;
using System.Windows.Forms;

namespace EquipmentAccounting
{
    public partial class MainForm : Form
    {
        private readonly AllDbForItContext _db = new AllDbForItContext();
        private Form _currentChildForm;
        public MainForm()
        {
            InitializeComponent();
            StartTree();
            _currentChildForm = null;

        }

        private void StartTree()
        {
            TreeNode referencesNode = new TreeNode("Справочники");
            referencesNode.Nodes.Add("Подразделения");
            referencesNode.Nodes.Add("Сотрудники");
            referencesNode.Nodes.Add("Типы оборудования");

            TreeNode accountingNode = new TreeNode("Учет");
            accountingNode.Nodes.Add("Оборудование");
            accountingNode.Nodes.Add("Лицензии ПО");
            accountingNode.Nodes.Add("Установленное ПО");
            accountingNode.Nodes.Add("История перемещений");
            accountingNode.Nodes.Add("Отчет");
            accountingNode.Nodes.Add("Список ПО на компьютере сотрудника X");

            treeView1.Nodes.Add(referencesNode);
            treeView1.Nodes.Add(accountingNode);

            treeView1.ExpandAll();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void типыОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_Window(new TypesOfEquipmentForm(), sender);
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_Window(new Staff(), sender);
        }

        private void подразделенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_Window(new DivisionForm(), sender);
        }

        private void оборудованиеПоПодразделениямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_Window(new EquipmentForm(), sender);
        }

        private void поНаКомпьютереСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_Window(new InstalledForm(), sender);
        }
        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_Window(new HistoryEquiSwap(), sender);
        }
        private void лицензииПОТоолStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_Window(new SoftwareLinsForm(), sender);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string message = e.Node.Text;

            switch (message)
            {
                case "Подразделения":
                    Open_Window(new DivisionForm(), sender);
                    break;
                case "Сотрудники":
                    Open_Window(new Staff(), sender);
                    break;
                case "Типы оборудования":
                    Open_Window(new TypesOfEquipmentForm(), sender);
                    break;
                case "Оборудование":
                    Open_Window(new EquipmentForm(), sender);
                    break;
                case "Лицензии ПО":
                    Open_Window(new SoftwareLinsForm(), sender);
                    break;
                case "История перемещений":
                    Open_Window(new HistoryEquiSwap(), sender);
                    break;
                case "Установленное ПО":
                    Open_Window(new InstalledForm(), sender);
                    break;
                case "Отчет":
                    Save_Work();
                    break;
                case "Список ПО на компьютере сотрудника X":
                    Save_Work2();
                    break;

            }
        }

        private void Save_Work2()
        {
            var allData = (from inst in _db.InstalledSoftwares
                           join equip in _db.Equipment on inst.EquipmentId equals equip.Id
                           join staff in _db.Staff on equip.ResponsibleStaffId equals staff.Id
                           join license in _db.SoftwareLicenses on inst.LicenseId equals license.Id
                           select new
                           {
                               staff.Fio,
                               equip.InventoryNumber,
                               license.SoftwareName,
                               license.ExpirationDate
                           }).ToList(); 

            var groupedData = allData
                .GroupBy(x => x.Fio)
                .OrderBy(g => g.Key);


            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=====================================");
            sb.AppendLine("     ПО НА КОМПЬЮТЕРАХ СОТРУДНИКОВ");
            sb.AppendLine("=====================================");
            sb.AppendLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
            sb.AppendLine();

            foreach (var employeeGroup in groupedData)
            {
                sb.AppendLine($"СОТРУДНИК: {employeeGroup.Key}");
                sb.AppendLine(new string('-', 60));
                foreach (var item in employeeGroup.OrderBy(x => x.InventoryNumber))
                {
                    sb.AppendLine($"ПК {item.InventoryNumber,-10} {item.SoftwareName,-40} до {item.ExpirationDate:dd.MM.yyyy}");
                }
                sb.AppendLine();
            }

            File.WriteAllText("Отчет_ПО_на_компьютерах.txt", sb.ToString(), Encoding.UTF8);
            MessageBox.Show("Отчет сохранен!");

        }

        private void Save_Work()
        {
            var data = from e in _db.Equipment
                       join d in _db.Divisions on e.Id equals d.Id
                       join s in _db.Staff on e.ResponsibleStaffId equals s.Id
                       select new { e.InventoryNumber, e.Name, DivisionName = d.Name, FIO = s.Fio };

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=====================================");
            sb.AppendLine("     ОБОРУДОВАНИЕ ПО ПОДРАЗДЕЛЕНИЯМ");
            sb.AppendLine("=====================================");
            sb.AppendLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
            sb.AppendLine();

            var groupedData = data.OrderBy(x => x.DivisionName).ThenBy(x => x.InventoryNumber).ToList();
            string lastDivision = "";
            foreach (var item in groupedData)
            {
                if (item.DivisionName != lastDivision)
                {
                    sb.AppendLine();
                    sb.AppendLine($"--- {item.DivisionName} ---");
                    lastDivision = item.DivisionName;
                }
                sb.AppendLine($"Инв.№ {item.InventoryNumber,-10} {item.Name,-40} {item.FIO}");
            }

            File.WriteAllText("Отчет_Оборудование_по_подразделениям.txt", sb.ToString(), Encoding.UTF8);
            MessageBox.Show("Отчет сохранен!");
        }

        private void Open_Window(Form form, object menuSender)
        {

            _currentChildForm?.Close();


            mainPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            form.Show();
            _currentChildForm = form;
        }

        private void вашIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
