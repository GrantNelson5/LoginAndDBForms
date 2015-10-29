namespace WindowsFormsApplication1
{
    partial class CreateNoteForm1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNoteForm1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGoalSheetButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.departureTime = new System.Windows.Forms.DateTimePicker();
            this.arrivalTime = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.objective_cb4 = new System.Windows.Forms.ComboBox();
            this.objective_cb3 = new System.Windows.Forms.ComboBox();
            this.objective_cb2 = new System.Windows.Forms.ComboBox();
            this.objective_cb1 = new System.Windows.Forms.ComboBox();
            this.objective4_rtb = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.details4_rtb = new System.Windows.Forms.RichTextBox();
            this.goal4EndTime = new System.Windows.Forms.DateTimePicker();
            this.goal4StartTime = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.objective3_rtb = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.details3_rtb = new System.Windows.Forms.RichTextBox();
            this.goal3EndTime = new System.Windows.Forms.DateTimePicker();
            this.goal3StartTime = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.objective2_rtb = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.objective1_rtb = new System.Windows.Forms.RichTextBox();
            this.details2_rtb = new System.Windows.Forms.RichTextBox();
            this.goal2EndTime = new System.Windows.Forms.DateTimePicker();
            this.goal2StartTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.participantName_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.details1_rtb = new System.Windows.Forms.RichTextBox();
            this.goal1EndTime = new System.Windows.Forms.DateTimePicker();
            this.goal1StartTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentDateTime_CF1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.contract_tb = new System.Windows.Forms.RichTextBox();
            this.departureTimeDesc_tb = new System.Windows.Forms.TextBox();
            this.arrivalTimeDesc_tb = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // addGoalSheetButton
            // 
            this.addGoalSheetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGoalSheetButton.Location = new System.Drawing.Point(22, 629);
            this.addGoalSheetButton.Name = "addGoalSheetButton";
            this.addGoalSheetButton.Size = new System.Drawing.Size(196, 44);
            this.addGoalSheetButton.TabIndex = 2;
            this.addGoalSheetButton.Text = "Add Goal Sheet";
            this.addGoalSheetButton.UseVisualStyleBackColor = true;
            this.addGoalSheetButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(315, 629);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 44);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(103, 70);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem2_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(1153, 629);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(125, 44);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next >>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 650);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "save as pdf";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1290, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(455, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(823, 583);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // departureTime
            // 
            this.departureTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.departureTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.departureTime.CustomFormat = "h:mm tt";
            this.departureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.departureTime.Location = new System.Drawing.Point(618, 578);
            this.departureTime.Name = "departureTime";
            this.departureTime.Size = new System.Drawing.Size(67, 20);
            this.departureTime.TabIndex = 113;
            this.departureTime.Value = new System.DateTime(2015, 10, 21, 15, 0, 0, 0);
            // 
            // arrivalTime
            // 
            this.arrivalTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.arrivalTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.arrivalTime.CustomFormat = "h:mm tt";
            this.arrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.arrivalTime.Location = new System.Drawing.Point(594, 146);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(67, 20);
            this.arrivalTime.TabIndex = 114;
            this.arrivalTime.Value = new System.DateTime(2015, 10, 21, 9, 0, 0, 0);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(495, 578);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(123, 20);
            this.label22.TabIndex = 154;
            this.label22.Text = "Departure Time:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(495, 146);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 20);
            this.label21.TabIndex = 153;
            this.label21.Text = "Arrival Time:";
            // 
            // objective_cb4
            // 
            this.objective_cb4.FormattingEnabled = true;
            this.objective_cb4.Items.AddRange(new object[] {
            "(D1)",
            "(D2)",
            "(D3)",
            "(D4)",
            "(D5)",
            "(D6)",
            "(D7)",
            "(D8)",
            "(D9)",
            "(D10)"});
            this.objective_cb4.Location = new System.Drawing.Point(1055, 376);
            this.objective_cb4.Name = "objective_cb4";
            this.objective_cb4.Size = new System.Drawing.Size(44, 21);
            this.objective_cb4.TabIndex = 136;
            this.objective_cb4.Text = "(D1)";
            // 
            // objective_cb3
            // 
            this.objective_cb3.FormattingEnabled = true;
            this.objective_cb3.Items.AddRange(new object[] {
            "(C1)",
            "(C2)",
            "(C3)",
            "(C4)",
            "(C5)",
            "(C6)",
            "(C7)",
            "(C8)",
            "(C9)",
            "(C10)"});
            this.objective_cb3.Location = new System.Drawing.Point(673, 377);
            this.objective_cb3.Name = "objective_cb3";
            this.objective_cb3.Size = new System.Drawing.Size(44, 21);
            this.objective_cb3.TabIndex = 128;
            this.objective_cb3.Text = "(C1)";
            // 
            // objective_cb2
            // 
            this.objective_cb2.FormattingEnabled = true;
            this.objective_cb2.Items.AddRange(new object[] {
            "(B1)",
            "(B2)",
            "(B3)",
            "(B4)",
            "(B5)",
            "(B6)",
            "(B7)",
            "(B8)",
            "(B9)",
            "(B10)"});
            this.objective_cb2.Location = new System.Drawing.Point(1055, 183);
            this.objective_cb2.Name = "objective_cb2";
            this.objective_cb2.Size = new System.Drawing.Size(44, 21);
            this.objective_cb2.TabIndex = 123;
            this.objective_cb2.Text = "(B1)";
            // 
            // objective_cb1
            // 
            this.objective_cb1.FormattingEnabled = true;
            this.objective_cb1.Items.AddRange(new object[] {
            "(A1)",
            "(A2)",
            "(A3)",
            "(A4)",
            "(A5)",
            "(A6)",
            "(A7)",
            "(A8)",
            "(A9)",
            "(A10)"});
            this.objective_cb1.Location = new System.Drawing.Point(673, 183);
            this.objective_cb1.Name = "objective_cb1";
            this.objective_cb1.Size = new System.Drawing.Size(44, 21);
            this.objective_cb1.TabIndex = 116;
            this.objective_cb1.Text = "(A1)";
            // 
            // objective4_rtb
            // 
            this.objective4_rtb.ContextMenuStrip = this.contextMenuStrip2;
            this.objective4_rtb.Location = new System.Drawing.Point(876, 400);
            this.objective4_rtb.Name = "objective4_rtb";
            this.objective4_rtb.Size = new System.Drawing.Size(365, 51);
            this.objective4_rtb.TabIndex = 137;
            this.objective4_rtb.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(872, 454);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(245, 20);
            this.label16.TabIndex = 151;
            this.label16.Text = "Details about this objective today:";
            // 
            // details4_rtb
            // 
            this.details4_rtb.ContextMenuStrip = this.contextMenuStrip2;
            this.details4_rtb.Location = new System.Drawing.Point(876, 477);
            this.details4_rtb.Name = "details4_rtb";
            this.details4_rtb.Size = new System.Drawing.Size(365, 51);
            this.details4_rtb.TabIndex = 140;
            this.details4_rtb.Text = "";
            // 
            // goal4EndTime
            // 
            this.goal4EndTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.goal4EndTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.goal4EndTime.CustomFormat = "h:mm tt";
            this.goal4EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goal4EndTime.Location = new System.Drawing.Point(1129, 534);
            this.goal4EndTime.Name = "goal4EndTime";
            this.goal4EndTime.Size = new System.Drawing.Size(67, 20);
            this.goal4EndTime.TabIndex = 142;
            this.goal4EndTime.Value = new System.DateTime(2015, 10, 21, 15, 0, 0, 0);
            // 
            // goal4StartTime
            // 
            this.goal4StartTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.goal4StartTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.goal4StartTime.CustomFormat = "h:mm tt";
            this.goal4StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goal4StartTime.Location = new System.Drawing.Point(978, 534);
            this.goal4StartTime.Name = "goal4StartTime";
            this.goal4StartTime.Size = new System.Drawing.Size(67, 20);
            this.goal4StartTime.TabIndex = 141;
            this.goal4StartTime.Value = new System.DateTime(2015, 10, 21, 14, 0, 0, 0);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1081, 533);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 20);
            this.label17.TabIndex = 150;
            this.label17.Text = "End:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(924, 534);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 20);
            this.label18.TabIndex = 149;
            this.label18.Text = "Start:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 42);
            this.label1.TabIndex = 110;
            this.label1.Text = "Create a new progress note";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(872, 377);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(177, 20);
            this.label19.TabIndex = 148;
            this.label19.Text = "Participant\'s Objective 4";
            // 
            // objective3_rtb
            // 
            this.objective3_rtb.ContextMenuStrip = this.contextMenuStrip2;
            this.objective3_rtb.Location = new System.Drawing.Point(493, 400);
            this.objective3_rtb.Name = "objective3_rtb";
            this.objective3_rtb.Size = new System.Drawing.Size(365, 51);
            this.objective3_rtb.TabIndex = 130;
            this.objective3_rtb.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(490, 454);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 20);
            this.label12.TabIndex = 147;
            this.label12.Text = "Details about this objective today:";
            // 
            // details3_rtb
            // 
            this.details3_rtb.ContextMenuStrip = this.contextMenuStrip2;
            this.details3_rtb.Location = new System.Drawing.Point(493, 477);
            this.details3_rtb.Name = "details3_rtb";
            this.details3_rtb.Size = new System.Drawing.Size(365, 51);
            this.details3_rtb.TabIndex = 132;
            this.details3_rtb.Text = "";
            // 
            // goal3EndTime
            // 
            this.goal3EndTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.goal3EndTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.goal3EndTime.CustomFormat = "h:mm tt";
            this.goal3EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goal3EndTime.Location = new System.Drawing.Point(746, 534);
            this.goal3EndTime.Name = "goal3EndTime";
            this.goal3EndTime.Size = new System.Drawing.Size(67, 20);
            this.goal3EndTime.TabIndex = 134;
            this.goal3EndTime.Value = new System.DateTime(2015, 10, 21, 14, 0, 0, 0);
            // 
            // goal3StartTime
            // 
            this.goal3StartTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.goal3StartTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.goal3StartTime.CustomFormat = "h:mm tt";
            this.goal3StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goal3StartTime.Location = new System.Drawing.Point(595, 534);
            this.goal3StartTime.Name = "goal3StartTime";
            this.goal3StartTime.Size = new System.Drawing.Size(67, 20);
            this.goal3StartTime.TabIndex = 133;
            this.goal3StartTime.Value = new System.DateTime(2015, 10, 21, 0, 30, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(698, 533);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 146;
            this.label13.Text = "End:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(541, 534);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 145;
            this.label14.Text = "Start:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(490, 377);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 20);
            this.label15.TabIndex = 144;
            this.label15.Text = "Participant\'s Objective 3";
            // 
            // objective2_rtb
            // 
            this.objective2_rtb.ContextMenuStrip = this.contextMenuStrip2;
            this.objective2_rtb.Location = new System.Drawing.Point(876, 206);
            this.objective2_rtb.Name = "objective2_rtb";
            this.objective2_rtb.Size = new System.Drawing.Size(365, 51);
            this.objective2_rtb.TabIndex = 124;
            this.objective2_rtb.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(872, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 20);
            this.label7.TabIndex = 143;
            this.label7.Text = "Details about this objective today:";
            // 
            // objective1_rtb
            // 
            this.objective1_rtb.ContextMenuStrip = this.contextMenuStrip2;
            this.objective1_rtb.Location = new System.Drawing.Point(493, 206);
            this.objective1_rtb.Name = "objective1_rtb";
            this.objective1_rtb.Size = new System.Drawing.Size(365, 51);
            this.objective1_rtb.TabIndex = 118;
            this.objective1_rtb.Text = "";
            // 
            // details2_rtb
            // 
            this.details2_rtb.ContextMenuStrip = this.contextMenuStrip2;
            this.details2_rtb.Location = new System.Drawing.Point(876, 283);
            this.details2_rtb.Name = "details2_rtb";
            this.details2_rtb.Size = new System.Drawing.Size(365, 50);
            this.details2_rtb.TabIndex = 125;
            this.details2_rtb.Text = "";
            // 
            // goal2EndTime
            // 
            this.goal2EndTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.goal2EndTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.goal2EndTime.CustomFormat = "h:mm tt";
            this.goal2EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goal2EndTime.Location = new System.Drawing.Point(1129, 340);
            this.goal2EndTime.Name = "goal2EndTime";
            this.goal2EndTime.Size = new System.Drawing.Size(67, 20);
            this.goal2EndTime.TabIndex = 127;
            this.goal2EndTime.Value = new System.DateTime(2015, 10, 21, 12, 30, 0, 0);
            // 
            // goal2StartTime
            // 
            this.goal2StartTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.goal2StartTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.goal2StartTime.CustomFormat = "h:mm tt";
            this.goal2StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goal2StartTime.Location = new System.Drawing.Point(978, 340);
            this.goal2StartTime.Name = "goal2StartTime";
            this.goal2StartTime.Size = new System.Drawing.Size(67, 20);
            this.goal2StartTime.TabIndex = 126;
            this.goal2StartTime.Value = new System.DateTime(2015, 10, 21, 11, 30, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1081, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 139;
            this.label8.Text = "End:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(924, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 138;
            this.label10.Text = "Start:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(872, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 20);
            this.label11.TabIndex = 135;
            this.label11.Text = "Participant\'s Objective 2";
            // 
            // participantName_tb
            // 
            this.participantName_tb.Location = new System.Drawing.Point(1059, 110);
            this.participantName_tb.Name = "participantName_tb";
            this.participantName_tb.Size = new System.Drawing.Size(160, 20);
            this.participantName_tb.TabIndex = 111;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(875, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 20);
            this.label6.TabIndex = 131;
            this.label6.Text = "Participant\'s Full Name: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(490, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 20);
            this.label9.TabIndex = 129;
            this.label9.Text = "Details about this objective today:";
            // 
            // details1_rtb
            // 
            this.details1_rtb.ContextMenuStrip = this.contextMenuStrip2;
            this.details1_rtb.Location = new System.Drawing.Point(493, 283);
            this.details1_rtb.Name = "details1_rtb";
            this.details1_rtb.Size = new System.Drawing.Size(365, 51);
            this.details1_rtb.TabIndex = 120;
            this.details1_rtb.Text = "";
            // 
            // goal1EndTime
            // 
            this.goal1EndTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.goal1EndTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.goal1EndTime.CustomFormat = "h:mm tt";
            this.goal1EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goal1EndTime.Location = new System.Drawing.Point(746, 340);
            this.goal1EndTime.Name = "goal1EndTime";
            this.goal1EndTime.Size = new System.Drawing.Size(67, 20);
            this.goal1EndTime.TabIndex = 122;
            this.goal1EndTime.Value = new System.DateTime(2015, 10, 21, 23, 30, 0, 0);
            // 
            // goal1StartTime
            // 
            this.goal1StartTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.goal1StartTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.goal1StartTime.CustomFormat = "h:mm tt";
            this.goal1StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goal1StartTime.Location = new System.Drawing.Point(595, 340);
            this.goal1StartTime.Name = "goal1StartTime";
            this.goal1StartTime.Size = new System.Drawing.Size(67, 20);
            this.goal1StartTime.TabIndex = 121;
            this.goal1StartTime.Value = new System.DateTime(2015, 10, 21, 10, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(698, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 119;
            this.label5.Text = "End:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 117;
            this.label4.Text = "Start:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 112;
            this.label3.Text = "Please Select Todays Date";
            // 
            // CurrentDateTime_CF1
            // 
            this.CurrentDateTime_CF1.CustomFormat = "(MM/dd/yy)";
            this.CurrentDateTime_CF1.Location = new System.Drawing.Point(732, 110);
            this.CurrentDateTime_CF1.Name = "CurrentDateTime_CF1";
            this.CurrentDateTime_CF1.Size = new System.Drawing.Size(104, 20);
            this.CurrentDateTime_CF1.TabIndex = 109;
            this.CurrentDateTime_CF1.Value = new System.DateTime(2015, 10, 21, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(490, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 108;
            this.label2.Text = "Participant\'s Objective 1";
            // 
            // contract_tb
            // 
            this.contract_tb.ContextMenuStrip = this.contextMenuStrip1;
            this.contract_tb.EnableAutoDragDrop = true;
            this.contract_tb.Location = new System.Drawing.Point(22, 40);
            this.contract_tb.Name = "contract_tb";
            this.contract_tb.ReadOnly = true;
            this.contract_tb.Size = new System.Drawing.Size(418, 583);
            this.contract_tb.TabIndex = 1;
            this.contract_tb.Text = "";
            // 
            // departureTimeDesc_tb
            // 
            this.departureTimeDesc_tb.Location = new System.Drawing.Point(713, 578);
            this.departureTimeDesc_tb.Name = "departureTimeDesc_tb";
            this.departureTimeDesc_tb.Size = new System.Drawing.Size(528, 20);
            this.departureTimeDesc_tb.TabIndex = 155;
            // 
            // arrivalTimeDesc_tb
            // 
            this.arrivalTimeDesc_tb.Location = new System.Drawing.Point(686, 146);
            this.arrivalTimeDesc_tb.Name = "arrivalTimeDesc_tb";
            this.arrivalTimeDesc_tb.Size = new System.Drawing.Size(555, 20);
            this.arrivalTimeDesc_tb.TabIndex = 156;
            // 
            // CreateNoteForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1290, 680);
            this.Controls.Add(this.arrivalTimeDesc_tb);
            this.Controls.Add(this.departureTimeDesc_tb);
            this.Controls.Add(this.departureTime);
            this.Controls.Add(this.arrivalTime);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.objective_cb4);
            this.Controls.Add(this.objective_cb3);
            this.Controls.Add(this.objective_cb2);
            this.Controls.Add(this.objective_cb1);
            this.Controls.Add(this.objective4_rtb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.details4_rtb);
            this.Controls.Add(this.goal4EndTime);
            this.Controls.Add(this.goal4StartTime);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.objective3_rtb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.details3_rtb);
            this.Controls.Add(this.goal3EndTime);
            this.Controls.Add(this.goal3StartTime);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.objective2_rtb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.objective1_rtb);
            this.Controls.Add(this.details2_rtb);
            this.Controls.Add(this.goal2EndTime);
            this.Controls.Add(this.goal2StartTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.participantName_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.details1_rtb);
            this.Controls.Add(this.goal1EndTime);
            this.Controls.Add(this.goal1StartTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CurrentDateTime_CF1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addGoalSheetButton);
            this.Controls.Add(this.contract_tb);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateNoteForm1";
            this.Text = "Super Note :: Progress Note";
            this.Load += new System.EventHandler(this.CreateNoteForm1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addGoalSheetButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker departureTime;
        private System.Windows.Forms.DateTimePicker arrivalTime;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox objective_cb4;
        private System.Windows.Forms.ComboBox objective_cb3;
        private System.Windows.Forms.ComboBox objective_cb2;
        private System.Windows.Forms.ComboBox objective_cb1;
        private System.Windows.Forms.RichTextBox objective4_rtb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox details4_rtb;
        private System.Windows.Forms.DateTimePicker goal4EndTime;
        private System.Windows.Forms.DateTimePicker goal4StartTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RichTextBox objective3_rtb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox details3_rtb;
        private System.Windows.Forms.DateTimePicker goal3EndTime;
        private System.Windows.Forms.DateTimePicker goal3StartTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox objective2_rtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox objective1_rtb;
        private System.Windows.Forms.RichTextBox details2_rtb;
        private System.Windows.Forms.DateTimePicker goal2EndTime;
        private System.Windows.Forms.DateTimePicker goal2StartTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox participantName_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox details1_rtb;
        private System.Windows.Forms.DateTimePicker goal1EndTime;
        private System.Windows.Forms.DateTimePicker goal1StartTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker CurrentDateTime_CF1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox contract_tb;
        private System.Windows.Forms.TextBox departureTimeDesc_tb;
        private System.Windows.Forms.TextBox arrivalTimeDesc_tb;
    }
}