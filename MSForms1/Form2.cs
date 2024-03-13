using System;
using System.Windows.Forms;

namespace MSForms1
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;
        private string selectedFormat;
        private bool isProfileAvailable;
        private string sgValue, mwValue, tbValue, ckValue = "";
        private string selectedInputType;
        public Form2(Form1 parentForm, string pSelectedFormat, bool pIsProfileAvailable, string psgValue, string pmwValue, string ptbValue, string pselectedInputType)
        {
            InitializeComponent();

            // Store the received data in member variables
            selectedFormat = pSelectedFormat;
            isProfileAvailable = pIsProfileAvailable;
            sgValue = psgValue;
            mwValue = pmwValue;
            tbValue = ptbValue;
            selectedInputType = pselectedInputType;
            this.parentForm = parentForm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TableLayoutPanel mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.ColumnCount = 4;
            mainTableLayoutPanel.RowCount = 1;

            CreateTable(mainTableLayoutPanel, "TBP");
            CreateTable(mainTableLayoutPanel, "ASTM_D1160");
            CreateTable(mainTableLayoutPanel, "ASTM_D86");
            CreateTable(mainTableLayoutPanel, "ASTM D2887");

            this.Controls.Add(mainTableLayoutPanel);
        }

        private void CreateTable(TableLayoutPanel parentTableLayoutPanel, string tableName)
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.RowCount = 10; // 9 rows + 1 for heading
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.Dock = DockStyle.Fill;
            //tableLayoutPanel.Width = 300;
            //tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            // Heading
            Label headingLabel = new Label();
            headingLabel.Text = tableName; 
            headingLabel.AutoSize = true;

            headingLabel.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            headingLabel.TextAlign = ContentAlignment.MiddleCenter;

            tableLayoutPanel.SetColumnSpan(headingLabel, 2);
            tableLayoutPanel.Controls.Add(headingLabel);

            Label sideLabel = new Label();
            sideLabel.Text = "% Vol";
            sideLabel.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            tableLayoutPanel.Controls.Add(sideLabel, 0, 1);
            Label sideLabel2 = new Label();
            sideLabel2.Text = "Temp";
            sideLabel2.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            tableLayoutPanel.Controls.Add(sideLabel2, 1, 1);
            // Add rows and columns
            for (int i = 2; i < 11; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Label textBox = new Label();
                    textBox.Text = $"{i},{j}"; 
                    tableLayoutPanel.Controls.Add(textBox, j, i);
                }
            }

            // Add the table to the main table
            parentTableLayoutPanel.Controls.Add(tableLayoutPanel);
        }
    }
}
