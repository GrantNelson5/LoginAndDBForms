namespace WindowsFormsApplication1
{
    partial class DatabaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yesSeizure_rb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.noSeizure_rb = new System.Windows.Forms.RadioButton();
            this.pid_tb = new System.Windows.Forms.TextBox();
            this.firstName_tb = new System.Windows.Forms.TextBox();
            this.lastName_tb = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.middleInitial_cb = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.female_rb = new System.Windows.Forms.RadioButton();
            this.male_rb = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noMeds_rb = new System.Windows.Forms.RadioButton();
            this.yesMeds_rb = new System.Windows.Forms.RadioButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.street_tb = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.city_tb = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.state_tb = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.zip_tb = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.emergencyName_tb = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.emergencyPhone_tb = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // yesSeizure_rb
            // 
            this.yesSeizure_rb.AutoSize = true;
            this.yesSeizure_rb.Location = new System.Drawing.Point(66, 25);
            this.yesSeizure_rb.Name = "yesSeizure_rb";
            this.yesSeizure_rb.Size = new System.Drawing.Size(51, 22);
            this.yesSeizure_rb.TabIndex = 8;
            this.yesSeizure_rb.TabStop = true;
            this.yesSeizure_rb.Text = "Yes";
            this.yesSeizure_rb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.noSeizure_rb);
            this.groupBox2.Controls.Add(this.yesSeizure_rb);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(228, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 59);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Does the Participant have seizures?";
            // 
            // noSeizure_rb
            // 
            this.noSeizure_rb.AutoSize = true;
            this.noSeizure_rb.Location = new System.Drawing.Point(148, 25);
            this.noSeizure_rb.Name = "noSeizure_rb";
            this.noSeizure_rb.Size = new System.Drawing.Size(46, 22);
            this.noSeizure_rb.TabIndex = 9;
            this.noSeizure_rb.Text = "No";
            this.noSeizure_rb.UseVisualStyleBackColor = true;
            // 
            // pid_tb
            // 
            this.pid_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid_tb.Location = new System.Drawing.Point(8, 22);
            this.pid_tb.Name = "pid_tb";
            this.pid_tb.Size = new System.Drawing.Size(100, 26);
            this.pid_tb.TabIndex = 1;
            // 
            // firstName_tb
            // 
            this.firstName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_tb.Location = new System.Drawing.Point(10, 22);
            this.firstName_tb.Name = "firstName_tb";
            this.firstName_tb.Size = new System.Drawing.Size(100, 26);
            this.firstName_tb.TabIndex = 2;
            // 
            // lastName_tb
            // 
            this.lastName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_tb.Location = new System.Drawing.Point(10, 23);
            this.lastName_tb.Name = "lastName_tb";
            this.lastName_tb.Size = new System.Drawing.Size(100, 26);
            this.lastName_tb.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 24);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(311, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(327, 31);
            this.label12.TabIndex = 27;
            this.label12.Text = "* Indicates a required field";
            // 
            // middleInitial_cb
            // 
            this.middleInitial_cb.FormattingEnabled = true;
            this.middleInitial_cb.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.middleInitial_cb.Location = new System.Drawing.Point(25, 22);
            this.middleInitial_cb.Name = "middleInitial_cb";
            this.middleInitial_cb.Size = new System.Drawing.Size(58, 26);
            this.middleInitial_cb.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pid_tb);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(28, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 59);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Participant ID *";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.firstName_tb);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(182, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(118, 59);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "First Name *";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lastName_tb);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(481, 71);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(118, 59);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Last Name *";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.middleInitial_cb);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(333, 71);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(116, 59);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Middle Initial *";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.female_rb);
            this.groupBox7.Controls.Add(this.male_rb);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(632, 71);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(209, 59);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Gender *";
            // 
            // female_rb
            // 
            this.female_rb.AutoSize = true;
            this.female_rb.Location = new System.Drawing.Point(118, 22);
            this.female_rb.Name = "female_rb";
            this.female_rb.Size = new System.Drawing.Size(75, 22);
            this.female_rb.TabIndex = 6;
            this.female_rb.TabStop = true;
            this.female_rb.Text = "Female";
            this.female_rb.UseVisualStyleBackColor = true;
            // 
            // male_rb
            // 
            this.male_rb.AutoSize = true;
            this.male_rb.Location = new System.Drawing.Point(32, 22);
            this.male_rb.Name = "male_rb";
            this.male_rb.Size = new System.Drawing.Size(58, 22);
            this.male_rb.TabIndex = 5;
            this.male_rb.TabStop = true;
            this.male_rb.Text = "Male";
            this.male_rb.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dateTimePicker1);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(74, 152);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(122, 59);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Birth Date *";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noMeds_rb);
            this.groupBox1.Controls.Add(this.yesMeds_rb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(517, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 59);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Does the Participant take medication?";
            // 
            // noMeds_rb
            // 
            this.noMeds_rb.AutoSize = true;
            this.noMeds_rb.Location = new System.Drawing.Point(148, 25);
            this.noMeds_rb.Name = "noMeds_rb";
            this.noMeds_rb.Size = new System.Drawing.Size(46, 22);
            this.noMeds_rb.TabIndex = 11;
            this.noMeds_rb.TabStop = true;
            this.noMeds_rb.Text = "No";
            this.noMeds_rb.UseVisualStyleBackColor = true;
            // 
            // yesMeds_rb
            // 
            this.yesMeds_rb.AutoSize = true;
            this.yesMeds_rb.Location = new System.Drawing.Point(66, 25);
            this.yesMeds_rb.Name = "yesMeds_rb";
            this.yesMeds_rb.Size = new System.Drawing.Size(51, 22);
            this.yesMeds_rb.TabIndex = 10;
            this.yesMeds_rb.TabStop = true;
            this.yesMeds_rb.Text = "Yes";
            this.yesMeds_rb.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.street_tb);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(162, 231);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(118, 59);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Street *";
            // 
            // street_tb
            // 
            this.street_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street_tb.Location = new System.Drawing.Point(10, 22);
            this.street_tb.Name = "street_tb";
            this.street_tb.Size = new System.Drawing.Size(100, 26);
            this.street_tb.TabIndex = 12;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.city_tb);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(316, 231);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(118, 59);
            this.groupBox10.TabIndex = 10;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "City *";
            // 
            // city_tb
            // 
            this.city_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_tb.Location = new System.Drawing.Point(10, 22);
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(100, 26);
            this.city_tb.TabIndex = 13;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.state_tb);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(467, 231);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(118, 59);
            this.groupBox11.TabIndex = 11;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "State *";
            // 
            // state_tb
            // 
            this.state_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state_tb.Location = new System.Drawing.Point(10, 22);
            this.state_tb.Name = "state_tb";
            this.state_tb.Size = new System.Drawing.Size(100, 26);
            this.state_tb.TabIndex = 14;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.zip_tb);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(615, 231);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(118, 59);
            this.groupBox12.TabIndex = 12;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Zip *";
            // 
            // zip_tb
            // 
            this.zip_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zip_tb.Location = new System.Drawing.Point(10, 22);
            this.zip_tb.Name = "zip_tb";
            this.zip_tb.Size = new System.Drawing.Size(100, 26);
            this.zip_tb.TabIndex = 15;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.emergencyName_tb);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(274, 315);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(160, 59);
            this.groupBox13.TabIndex = 13;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Emergency Name *";
            // 
            // emergencyName_tb
            // 
            this.emergencyName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencyName_tb.Location = new System.Drawing.Point(8, 22);
            this.emergencyName_tb.Name = "emergencyName_tb";
            this.emergencyName_tb.Size = new System.Drawing.Size(144, 26);
            this.emergencyName_tb.TabIndex = 16;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.emergencyPhone_tb);
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.Location = new System.Drawing.Point(467, 315);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(160, 59);
            this.groupBox14.TabIndex = 14;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Emergency Phone *";
            // 
            // emergencyPhone_tb
            // 
            this.emergencyPhone_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencyPhone_tb.Location = new System.Drawing.Point(8, 22);
            this.emergencyPhone_tb.Name = "emergencyPhone_tb";
            this.emergencyPhone_tb.Size = new System.Drawing.Size(144, 26);
            this.emergencyPhone_tb.TabIndex = 17;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(289, 393);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(145, 40);
            this.addButton.TabIndex = 28;
            this.addButton.Text = "Add Participant";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(467, 393);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(145, 40);
            this.clearButton.TabIndex = 29;
            this.clearButton.Text = "Clear Form";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(870, 445);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form2";
            this.Text = "Super Note :: Manage Participants";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton yesSeizure_rb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton noSeizure_rb;
        private System.Windows.Forms.TextBox pid_tb;
        private System.Windows.Forms.TextBox firstName_tb;
        private System.Windows.Forms.TextBox lastName_tb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox middleInitial_cb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton female_rb;
        private System.Windows.Forms.RadioButton male_rb;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton noMeds_rb;
        private System.Windows.Forms.RadioButton yesMeds_rb;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox street_tb;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox city_tb;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox state_tb;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox zip_tb;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox emergencyName_tb;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox emergencyPhone_tb;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
    }
}