namespace MSForms1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            ASTM_D1160 = new RadioButton();
            ASTM_D86 = new RadioButton();
            ASTM_D2887 = new RadioButton();
            TBP = new RadioButton();
            SG_TextBox = new TextBox();
            Mx_TextBox = new TextBox();
            Tb_TextBox = new TextBox();
            Volume = new RadioButton();
            Weight = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            SG = new CheckBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            Error_Box = new GroupBox();
            Error_Label = new Label();
            rowCountValue = new NumericUpDown();
            RowCount = new Label();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            richTextBox13 = new RichTextBox();
            richTextBox14 = new RichTextBox();
            TableTab = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            Error_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rowCountValue).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(588, 488);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Next >";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ASTM_D1160
            // 
            ASTM_D1160.AutoSize = true;
            ASTM_D1160.Location = new Point(165, 0);
            ASTM_D1160.Name = "ASTM_D1160";
            ASTM_D1160.Size = new Size(116, 24);
            ASTM_D1160.TabIndex = 3;
            ASTM_D1160.TabStop = true;
            ASTM_D1160.Text = "ASTM D1160";
            ASTM_D1160.UseVisualStyleBackColor = true;
            ASTM_D1160.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // ASTM_D86
            // 
            ASTM_D86.AutoSize = true;
            ASTM_D86.Location = new Point(287, 0);
            ASTM_D86.Name = "ASTM_D86";
            ASTM_D86.Size = new Size(100, 24);
            ASTM_D86.TabIndex = 4;
            ASTM_D86.TabStop = true;
            ASTM_D86.Text = "ASTM D86";
            ASTM_D86.UseVisualStyleBackColor = true;
            // 
            // ASTM_D2887
            // 
            ASTM_D2887.AutoSize = true;
            ASTM_D2887.Location = new Point(393, 0);
            ASTM_D2887.Name = "ASTM_D2887";
            ASTM_D2887.Size = new Size(116, 24);
            ASTM_D2887.TabIndex = 5;
            ASTM_D2887.TabStop = true;
            ASTM_D2887.Text = "ASTM D2887";
            ASTM_D2887.UseVisualStyleBackColor = true;
            ASTM_D2887.CheckedChanged += ASTM_D2887_CheckedChanged;
            // 
            // TBP
            // 
            TBP.AutoSize = true;
            TBP.Location = new Point(515, 0);
            TBP.Name = "TBP";
            TBP.Size = new Size(55, 24);
            TBP.TabIndex = 6;
            TBP.TabStop = true;
            TBP.Text = "TBP";
            TBP.UseVisualStyleBackColor = true;
            // 
            // SG_TextBox
            // 
            SG_TextBox.Location = new Point(166, 0);
            SG_TextBox.Name = "SG_TextBox";
            SG_TextBox.Size = new Size(125, 27);
            SG_TextBox.TabIndex = 11;
            // 
            // Mx_TextBox
            // 
            Mx_TextBox.Location = new Point(356, 0);
            Mx_TextBox.Name = "Mx_TextBox";
            Mx_TextBox.Size = new Size(125, 27);
            Mx_TextBox.TabIndex = 12;
            // 
            // Tb_TextBox
            // 
            Tb_TextBox.Location = new Point(539, 0);
            Tb_TextBox.Name = "Tb_TextBox";
            Tb_TextBox.Size = new Size(125, 27);
            Tb_TextBox.TabIndex = 13;
            // 
            // Volume
            // 
            Volume.AutoSize = true;
            Volume.Location = new Point(98, 0);
            Volume.Name = "Volume";
            Volume.Size = new Size(96, 24);
            Volume.TabIndex = 15;
            Volume.TabStop = true;
            Volume.Text = "Volume %";
            Volume.UseVisualStyleBackColor = true;
            Volume.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // Weight
            // 
            Weight.AutoSize = true;
            Weight.Location = new Point(214, 0);
            Weight.Name = "Weight";
            Weight.Size = new Size(93, 24);
            Weight.TabIndex = 16;
            Weight.TabStop = true;
            Weight.Text = "Weight %";
            Weight.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ASTM_D86);
            groupBox1.Controls.Add(ASTM_D1160);
            groupBox1.Controls.Add(ASTM_D2887);
            groupBox1.Controls.Add(TBP);
            groupBox1.Location = new Point(18, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(649, 33);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "INPUT DATA FORMAT: ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SG);
            groupBox2.Location = new Point(18, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 38);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Available Profile: ";
            // 
            // SG
            // 
            SG.AutoSize = true;
            SG.Location = new Point(165, -2);
            SG.Name = "SG";
            SG.Size = new Size(49, 24);
            SG.TabIndex = 15;
            SG.Text = "SG";
            SG.UseVisualStyleBackColor = true;
            SG.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(SG_TextBox);
            groupBox3.Controls.Add(Mx_TextBox);
            groupBox3.Controls.Add(Tb_TextBox);
            groupBox3.Location = new Point(18, 105);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(664, 36);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bulk Properties: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 3);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 16;
            label3.Text = "Tb:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 3);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 15;
            label2.Text = "Mw:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 3);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 14;
            label1.Text = "SG: ";
            label1.Click += label1_Click_2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Volume);
            groupBox4.Controls.Add(Weight);
            groupBox4.Location = new Point(21, 147);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(354, 32);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "Input Type: ";
            // 
            // Error_Box
            // 
            Error_Box.Controls.Add(Error_Label);
            Error_Box.Location = new Point(99, 483);
            Error_Box.Name = "Error_Box";
            Error_Box.Size = new Size(452, 37);
            Error_Box.TabIndex = 20;
            Error_Box.TabStop = false;
            Error_Box.Enter += groupBox6_Enter;
            // 
            // Error_Label
            // 
            Error_Label.AutoSize = true;
            Error_Label.Location = new Point(94, 14);
            Error_Label.Name = "Error_Label";
            Error_Label.Size = new Size(0, 20);
            Error_Label.TabIndex = 0;
            Error_Label.Click += Error_Label_Click;
            // 
            // rowCountValue
            // 
            rowCountValue.Location = new Point(184, 187);
            rowCountValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            rowCountValue.Name = "rowCountValue";
            rowCountValue.Size = new Size(95, 27);
            rowCountValue.TabIndex = 21;
            rowCountValue.Value = new decimal(new int[] { 3, 0, 0, 0 });
            rowCountValue.ValueChanged += rowCountValue_ValueChanged;
            // 
            // RowCount
            // 
            RowCount.AutoSize = true;
            RowCount.Location = new Point(21, 189);
            RowCount.Name = "RowCount";
            RowCount.Size = new Size(148, 20);
            RowCount.TabIndex = 23;
            RowCount.Text = "No of Rows in Table: ";
            RowCount.Click += RowCount_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 249F));
            tableLayoutPanel3.Controls.Add(richTextBox13, 0, 2);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // richTextBox13
            // 
            richTextBox13.Location = new Point(3, 3);
            richTextBox13.Name = "richTextBox13";
            richTextBox13.Size = new Size(1, 37);
            richTextBox13.TabIndex = 12;
            richTextBox13.Text = "";
            // 
            // richTextBox14
            // 
            richTextBox14.Location = new Point(3, 3);
            richTextBox14.Name = "richTextBox14";
            richTextBox14.Size = new Size(1, 37);
            richTextBox14.TabIndex = 11;
            richTextBox14.Text = "";
            // 
            // TableTab
            // 
            TableTab.Location = new Point(24, 220);
            TableTab.Name = "TableTab";
            TableTab.Size = new Size(658, 257);
            TableTab.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 532);
            Controls.Add(TableTab);
            Controls.Add(button1);
            Controls.Add(RowCount);
            Controls.Add(rowCountValue);
            Controls.Add(Error_Box);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "GUI";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            Error_Box.ResumeLayout(false);
            Error_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rowCountValue).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private RadioButton ASTM_D1160;
        private RadioButton ASTM_D86;
        private RadioButton ASTM_D2887;
        private RadioButton TBP;
        private TextBox SG_TextBox;
        private TextBox Mx_TextBox;
        private TextBox Tb_TextBox;
        private RadioButton Volume;
        private RadioButton Weight;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox SG;
        private GroupBox Error_Box;
        private Label Error_Label;
        private NumericUpDown rowCountValue;
        private Label RowCount;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private RichTextBox richTextBox13;
        private RichTextBox richTextBox14;
        private Panel TableTab;
    }
}
