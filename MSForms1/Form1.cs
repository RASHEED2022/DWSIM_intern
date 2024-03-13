namespace MSForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            displayTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string selectedFormat;
            bool isProfileAvailable;
            string sgValue, mwValue, tbValue, ckValue = "";
            string selectedInputType;

            if (ASTM_D1160.Checked)
            {
                selectedFormat = "ASTM D1160";
            }
            else if (ASTM_D86.Checked)
            {
                selectedFormat = "ASTM D86";
            }
            else if (ASTM_D2887.Checked)
            {
                selectedFormat = "ASTM D2887";
            }
            else if (TBP.Checked)
            {
                selectedFormat = "TBP";
            }
            else
            {
                selectedFormat = "Blank";
            }

            // Get the checkbox state
            isProfileAvailable = SG.Checked;

            sgValue = SG_TextBox.Text;
            mwValue = Mx_TextBox.Text;
            tbValue = Tb_TextBox.Text;

            int ckInt;
            bool isInteger1 = int.TryParse(sgValue, out ckInt);
            bool isInteger2 = int.TryParse(mwValue, out ckInt);
            bool isInteger3 = int.TryParse(tbValue, out ckInt);

            if (!(isInteger1))
            {
                ckValue = "Error";
            }

            if (sgValue == null || sgValue == "")
            {
                ckValue = "Blank";
            }

            if (Volume.Checked)
            {
                selectedInputType = "Volume";
            }
            else if (Weight.Checked)
            {
                selectedInputType = "Weight";
            }
            else
            {
                selectedInputType = "Blank";
            }
            if ((selectedFormat != "Blank") && (ckValue != "Blank") && (selectedInputType != "Blank"))
            {
                Error_Label.Text = "";
                Form2 secondForm = new Form2(this, selectedFormat, isProfileAvailable, sgValue, mwValue, tbValue, selectedInputType);
                secondForm.ShowDialog();
                this.Close();   
            }
            else if (selectedFormat == "Blank")
            {
                DisplayError("Select the Input Data Format!");
            }
            else if (ckValue == "Blank")
            {
                DisplayError("SG value should not be Empty!");
            }
            else if (ckValue == "Error")
            {
                DisplayError("SG value should be Integer!");
            }
            else if (selectedInputType == "Blank")
            {
                DisplayError("Select the Input Type!");
            }
        }
        public void DisplayError(string ErrorMessage)
        {
            Error_Label.Text = ErrorMessage;
            Error_Label.ForeColor = Color.Red;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //tableLayoutPanel1_Paint_2(sender,e);
            displayTable();
        }
        private void rowCountValue_ValueChanged(object sender, EventArgs e)
        {
            displayTable();
        }
        private void displayTable()
        {
            TableTab.Controls.Clear();

            bool isProfileAvailable = SG.Checked;
            decimal currentValue = rowCountValue.Value;

            TableLayoutPanel mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.ColumnCount = 3;
            mainTableLayoutPanel.RowCount = 1;

            CreateTable(mainTableLayoutPanel, (int)currentValue, "% Volume or Weight ");
            CreateTable(mainTableLayoutPanel, (int)currentValue, "Temperature");
            if (isProfileAvailable)
            {
                CreateTable(mainTableLayoutPanel, (int)currentValue, "SG");
            }

            this.TableTab.Controls.Add(mainTableLayoutPanel);
        }
        private void CreateTable(TableLayoutPanel parentTableLayoutPanel, int count, string tableName)
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.RowCount = count + 1; // 9 rows + 1 for heading
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.Dock = DockStyle.Fill;
            //tableLayoutPanel.Width = 300;
            //tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            // Heading
            Label headingLabel = new Label();
            headingLabel.Text = tableName;
            headingLabel.AutoSize = true;

            headingLabel.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            headingLabel.TextAlign = ContentAlignment.MiddleCenter;
            tableLayoutPanel.Controls.Add(headingLabel);

            for (int i = 1; i <= count; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Text = " "; 
                textBox.AutoSize = true;
                tableLayoutPanel.Controls.Add(textBox, 0, i);
            }
            tableLayoutPanel.AutoSize = true;
            parentTableLayoutPanel.Controls.Add(tableLayoutPanel);

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void ASTM_D2887_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void Error_Label_Click(object sender, EventArgs e)
        {

        }

        private void RowCount_Click(object sender, EventArgs e)
        {

        }


        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
