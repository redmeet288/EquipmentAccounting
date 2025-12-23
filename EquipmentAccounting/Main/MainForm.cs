using System.Windows.Forms;
using EquipmentAccounting.Equipment;

namespace EquipmentAccounting
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartTree();

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

            TreeNode reportsNode = new TreeNode("Отчеты");
            reportsNode.Nodes.Add("Оборудование по подразделениям");
            reportsNode.Nodes.Add("ПО на компьютере сотрудника");

            treeView1.Nodes.Add(referencesNode);
            treeView1.Nodes.Add(accountingNode);
            treeView1.Nodes.Add(reportsNode);

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
            mainPanel.Controls.Clear();
            TypesOfEquipmentForm eq = new TypesOfEquipmentForm();
            eq.TopLevel = false;
            eq.FormBorderStyle = FormBorderStyle.None;
            eq.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(eq);
            eq.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Staff eq = new Staff();
            eq.TopLevel = false;
            eq.FormBorderStyle = FormBorderStyle.None;
            eq.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(eq);
            eq.Show();
        }

        private void подразделенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            DivisionForm division = new DivisionForm();
            division.TopLevel = false;
            division.FormBorderStyle = FormBorderStyle.None;
            division.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(division);
            division.Show();
        }

        private void оборудованиеПоПодразделениямToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поНаКомпьютереСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

            if (message == "Подразделения")
            {
                //fdsfsdfsdfsd
            }
            ////остальнное
        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            EquipmentForm division = new EquipmentForm();
            division.TopLevel = false;
            division.FormBorderStyle = FormBorderStyle.None;
            division.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(division);
            division.Show();
        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            HistoryEquiSwap division = new HistoryEquiSwap();
            division.TopLevel = false;
            division.FormBorderStyle = FormBorderStyle.None;
            division.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(division);
            division.Show();
        }
    }
}
