namespace Software_Development
{
    partial class CalendarPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarPage));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonResources = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMessaging = new System.Windows.Forms.Button();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonForum = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelSchedDescrip = new System.Windows.Forms.Label();
            this.labelPersonalSched = new System.Windows.Forms.Label();
            this.panelViewList = new System.Windows.Forms.Panel();
            this.buttonAddAss = new System.Windows.Forms.Button();
            this.checkedListBoxAssignments = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.labelEventsFor = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelEventDescription = new System.Windows.Forms.Label();
            this.labelDescriptionHeader = new System.Windows.Forms.Label();
            this.comboBoxFilters = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelAddNew = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddFinish = new System.Windows.Forms.Button();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.labelProfile = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelViewList.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelAddNew.SuspendLayout();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.pictureBoxLogout);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.pictureBoxClose);
            this.panelHeader.Location = new System.Drawing.Point(231, -2);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1056, 82);
            this.panelHeader.TabIndex = 38;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // pictureBoxLogout
            // 
            this.pictureBoxLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogout.Image = global::Software_Development.Properties.Resources.logout;
            this.pictureBoxLogout.Location = new System.Drawing.Point(972, 1);
            this.pictureBoxLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxLogout.Name = "pictureBoxLogout";
            this.pictureBoxLogout.Size = new System.Drawing.Size(40, 43);
            this.pictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogout.TabIndex = 25;
            this.pictureBoxLogout.TabStop = false;
            this.pictureBoxLogout.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calendar";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::Software_Development.Properties.Resources.xicon;
            this.pictureBoxClose.Location = new System.Drawing.Point(1013, 9);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(28, 27);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 24;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.buttonResources);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonMessaging);
            this.panel1.Controls.Add(this.buttonCalendar);
            this.panel1.Controls.Add(this.buttonForum);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Location = new System.Drawing.Point(-1, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 585);
            this.panel1.TabIndex = 36;
            // 
            // buttonResources
            // 
            this.buttonResources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonResources.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonResources.FlatAppearance.BorderSize = 0;
            this.buttonResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResources.Font = new System.Drawing.Font("Segoe UI Semilight", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResources.ForeColor = System.Drawing.Color.White;
            this.buttonResources.Image = global::Software_Development.Properties.Resources.book;
            this.buttonResources.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResources.Location = new System.Drawing.Point(0, 354);
            this.buttonResources.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonResources.Name = "buttonResources";
            this.buttonResources.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.buttonResources.Size = new System.Drawing.Size(232, 89);
            this.buttonResources.TabIndex = 57;
            this.buttonResources.Text = "  Resources";
            this.buttonResources.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonResources.UseVisualStyleBackColor = false;
            this.buttonResources.Click += new System.EventHandler(this.buttonResources_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 510);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 46);
            this.label3.TabIndex = 27;
            this.label3.Text = "Edutalk";
            // 
            // buttonMessaging
            // 
            this.buttonMessaging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonMessaging.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonMessaging.FlatAppearance.BorderSize = 0;
            this.buttonMessaging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMessaging.Font = new System.Drawing.Font("Segoe UI Semilight", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMessaging.ForeColor = System.Drawing.Color.White;
            this.buttonMessaging.Image = global::Software_Development.Properties.Resources.messages;
            this.buttonMessaging.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMessaging.Location = new System.Drawing.Point(0, 266);
            this.buttonMessaging.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonMessaging.Name = "buttonMessaging";
            this.buttonMessaging.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.buttonMessaging.Size = new System.Drawing.Size(232, 89);
            this.buttonMessaging.TabIndex = 56;
            this.buttonMessaging.Text = "  Messaging";
            this.buttonMessaging.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMessaging.UseVisualStyleBackColor = false;
            this.buttonMessaging.Click += new System.EventHandler(this.buttonMessaging_Click);
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonCalendar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonCalendar.FlatAppearance.BorderSize = 0;
            this.buttonCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalendar.Font = new System.Drawing.Font("Segoe UI Semilight", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalendar.ForeColor = System.Drawing.Color.White;
            this.buttonCalendar.Image = global::Software_Development.Properties.Resources.calendar;
            this.buttonCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalendar.Location = new System.Drawing.Point(0, 89);
            this.buttonCalendar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.buttonCalendar.Size = new System.Drawing.Size(232, 89);
            this.buttonCalendar.TabIndex = 54;
            this.buttonCalendar.Text = "  Calendar";
            this.buttonCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCalendar.UseVisualStyleBackColor = false;
            // 
            // buttonForum
            // 
            this.buttonForum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonForum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonForum.FlatAppearance.BorderSize = 0;
            this.buttonForum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForum.Font = new System.Drawing.Font("Segoe UI Semilight", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForum.ForeColor = System.Drawing.Color.White;
            this.buttonForum.Image = global::Software_Development.Properties.Resources.forum;
            this.buttonForum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonForum.Location = new System.Drawing.Point(0, 177);
            this.buttonForum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonForum.Name = "buttonForum";
            this.buttonForum.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.buttonForum.Size = new System.Drawing.Size(232, 89);
            this.buttonForum.TabIndex = 55;
            this.buttonForum.Text = "  Forum";
            this.buttonForum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonForum.UseVisualStyleBackColor = false;
            this.buttonForum.Click += new System.EventHandler(this.buttonForum_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI Semilight", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(232, 89);
            this.buttonHome.TabIndex = 53;
            this.buttonHome.Text = "  Home";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click_1);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Segoe UI", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(260, 346);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 39;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.labelSchedDescrip);
            this.panel4.Controls.Add(this.labelPersonalSched);
            this.panel4.Location = new System.Drawing.Point(260, 102);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(592, 229);
            this.panel4.TabIndex = 40;
            // 
            // labelSchedDescrip
            // 
            this.labelSchedDescrip.AutoSize = true;
            this.labelSchedDescrip.Font = new System.Drawing.Font("Segoe UI Light", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchedDescrip.ForeColor = System.Drawing.Color.White;
            this.labelSchedDescrip.Location = new System.Drawing.Point(12, 66);
            this.labelSchedDescrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSchedDescrip.Name = "labelSchedDescrip";
            this.labelSchedDescrip.Size = new System.Drawing.Size(201, 92);
            this.labelSchedDescrip.TabIndex = 2;
            this.labelSchedDescrip.Text = "- School 7:40AM - 2:00PM\r\n- Club Meeting 2:30PM\r\n- Dinner 6:00PM\r\n- Soccer Practi" +
    "ce 8:00PM\r\n";
            // 
            // labelPersonalSched
            // 
            this.labelPersonalSched.AutoSize = true;
            this.labelPersonalSched.Font = new System.Drawing.Font("Segoe UI Semilight", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonalSched.ForeColor = System.Drawing.Color.White;
            this.labelPersonalSched.Location = new System.Drawing.Point(172, 14);
            this.labelPersonalSched.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPersonalSched.Name = "labelPersonalSched";
            this.labelPersonalSched.Size = new System.Drawing.Size(202, 28);
            this.labelPersonalSched.TabIndex = 1;
            this.labelPersonalSched.Text = "My Schedule for Today";
            // 
            // panelViewList
            // 
            this.panelViewList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panelViewList.Controls.Add(this.buttonAddAss);
            this.panelViewList.Controls.Add(this.checkedListBoxAssignments);
            this.panelViewList.Controls.Add(this.label4);
            this.panelViewList.Location = new System.Drawing.Point(872, 101);
            this.panelViewList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelViewList.Name = "panelViewList";
            this.panelViewList.Size = new System.Drawing.Size(385, 230);
            this.panelViewList.TabIndex = 41;
            // 
            // buttonAddAss
            // 
            this.buttonAddAss.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddAss.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.buttonAddAss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAss.Font = new System.Drawing.Font("Segoe UI Light", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAss.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonAddAss.Location = new System.Drawing.Point(27, 167);
            this.buttonAddAss.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddAss.Name = "buttonAddAss";
            this.buttonAddAss.Size = new System.Drawing.Size(341, 38);
            this.buttonAddAss.TabIndex = 43;
            this.buttonAddAss.Text = "Add an Assignment";
            this.buttonAddAss.UseVisualStyleBackColor = false;
            this.buttonAddAss.Click += new System.EventHandler(this.buttonAddAss_Click);
            // 
            // checkedListBoxAssignments
            // 
            this.checkedListBoxAssignments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.checkedListBoxAssignments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxAssignments.CheckOnClick = true;
            this.checkedListBoxAssignments.Font = new System.Drawing.Font("Segoe UI Semilight", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxAssignments.ForeColor = System.Drawing.Color.White;
            this.checkedListBoxAssignments.FormattingEnabled = true;
            this.checkedListBoxAssignments.Items.AddRange(new object[] {
            "Math Homework",
            "Study with Emily for Physics",
            "History Test",
            "Orchestra Rehearsal"});
            this.checkedListBoxAssignments.Location = new System.Drawing.Point(20, 50);
            this.checkedListBoxAssignments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxAssignments.Name = "checkedListBoxAssignments";
            this.checkedListBoxAssignments.Size = new System.Drawing.Size(343, 80);
            this.checkedListBoxAssignments.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(64, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Upcoming Assignments";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Light", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonAdd.Location = new System.Drawing.Point(616, 567);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(341, 62);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Add an Event";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel6.Controls.Add(this.listBoxEvents);
            this.panel6.Controls.Add(this.labelEventsFor);
            this.panel6.Location = new System.Drawing.Point(616, 346);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(341, 197);
            this.panel6.TabIndex = 42;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.listBoxEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxEvents.Font = new System.Drawing.Font("Segoe UI Semilight", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.ForeColor = System.Drawing.Color.White;
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Items.AddRange(new object[] {
            "Orchestra Concert",
            "Basketball Game"});
            this.listBoxEvents.Location = new System.Drawing.Point(15, 49);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(303, 60);
            this.listBoxEvents.TabIndex = 45;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // labelEventsFor
            // 
            this.labelEventsFor.AutoSize = true;
            this.labelEventsFor.Font = new System.Drawing.Font("Segoe UI Semilight", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventsFor.ForeColor = System.Drawing.Color.White;
            this.labelEventsFor.Location = new System.Drawing.Point(64, 16);
            this.labelEventsFor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEventsFor.MaximumSize = new System.Drawing.Size(333, 31);
            this.labelEventsFor.Name = "labelEventsFor";
            this.labelEventsFor.Size = new System.Drawing.Size(156, 28);
            this.labelEventsFor.TabIndex = 0;
            this.labelEventsFor.Text = "Events for <day>";
            this.labelEventsFor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel7.Controls.Add(this.labelEventDescription);
            this.panel7.Controls.Add(this.labelDescriptionHeader);
            this.panel7.Location = new System.Drawing.Point(977, 346);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(281, 281);
            this.panel7.TabIndex = 46;
            // 
            // labelEventDescription
            // 
            this.labelEventDescription.AutoSize = true;
            this.labelEventDescription.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventDescription.ForeColor = System.Drawing.Color.White;
            this.labelEventDescription.Location = new System.Drawing.Point(12, 59);
            this.labelEventDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEventDescription.MaximumSize = new System.Drawing.Size(240, 369);
            this.labelEventDescription.Name = "labelEventDescription";
            this.labelEventDescription.Size = new System.Drawing.Size(42, 23);
            this.labelEventDescription.TabIndex = 2;
            this.labelEventDescription.Text = "filler";
            // 
            // labelDescriptionHeader
            // 
            this.labelDescriptionHeader.AutoSize = true;
            this.labelDescriptionHeader.Font = new System.Drawing.Font("Segoe UI Semilight", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptionHeader.ForeColor = System.Drawing.Color.White;
            this.labelDescriptionHeader.Location = new System.Drawing.Point(35, 16);
            this.labelDescriptionHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescriptionHeader.Name = "labelDescriptionHeader";
            this.labelDescriptionHeader.Size = new System.Drawing.Size(166, 28);
            this.labelDescriptionHeader.TabIndex = 1;
            this.labelDescriptionHeader.Text = "No event selected.";
            this.labelDescriptionHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxFilters
            // 
            this.comboBoxFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilters.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilters.FormattingEnabled = true;
            this.comboBoxFilters.Items.AddRange(new object[] {
            "All"});
            this.comboBoxFilters.Location = new System.Drawing.Point(373, 603);
            this.comboBoxFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(196, 23);
            this.comboBoxFilters.TabIndex = 47;
            this.comboBoxFilters.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 606);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Filter By:";
            // 
            // panelAddNew
            // 
            this.panelAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panelAddNew.Controls.Add(this.buttonCancel);
            this.panelAddNew.Controls.Add(this.buttonAddFinish);
            this.panelAddNew.Controls.Add(this.textBoxNewName);
            this.panelAddNew.Controls.Add(this.label7);
            this.panelAddNew.Controls.Add(this.label5);
            this.panelAddNew.Location = new System.Drawing.Point(873, 102);
            this.panelAddNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAddNew.Name = "panelAddNew";
            this.panelAddNew.Size = new System.Drawing.Size(385, 229);
            this.panelAddNew.TabIndex = 51;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI Light", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonCancel.Location = new System.Drawing.Point(25, 121);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(341, 38);
            this.buttonCancel.TabIndex = 52;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddFinish
            // 
            this.buttonAddFinish.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddFinish.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.buttonAddFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFinish.Font = new System.Drawing.Font("Segoe UI Light", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFinish.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonAddFinish.Location = new System.Drawing.Point(25, 171);
            this.buttonAddFinish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddFinish.Name = "buttonAddFinish";
            this.buttonAddFinish.Size = new System.Drawing.Size(341, 38);
            this.buttonAddFinish.TabIndex = 51;
            this.buttonAddFinish.Text = "Add to List";
            this.buttonAddFinish.UseVisualStyleBackColor = false;
            this.buttonAddFinish.Click += new System.EventHandler(this.buttonAddFinish_Click);
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(109, 66);
            this.textBoxNewName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(256, 22);
            this.textBoxNewName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(63, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Upcoming Assignments";
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panelProfile.Controls.Add(this.labelProfile);
            this.panelProfile.Controls.Add(this.pictureBoxProfile);
            this.panelProfile.Location = new System.Drawing.Point(-1, -2);
            this.panelProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(232, 82);
            this.panelProfile.TabIndex = 58;
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelProfile.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.ForeColor = System.Drawing.Color.White;
            this.labelProfile.Location = new System.Drawing.Point(92, 30);
            this.labelProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(92, 21);
            this.labelProfile.TabIndex = 1;
            this.labelProfile.Text = "My Account";
            this.labelProfile.Click += new System.EventHandler(this.labelProfile_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxProfile.Image = global::Software_Development.Properties.Resources.robot;
            this.pictureBoxProfile.Location = new System.Drawing.Point(36, 17);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(52, 48);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // CalendarPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1285, 663);
            this.Controls.Add(this.panelViewList);
            this.Controls.Add(this.panelProfile);
            this.Controls.Add(this.panelAddNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxFilters);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CalendarPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.Shown += new System.EventHandler(this.CalendarPage_Shown);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelViewList.ResumeLayout(false);
            this.panelViewList.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelAddNew.ResumeLayout(false);
            this.panelAddNew.PerformLayout();
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelViewList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPersonalSched;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelEventsFor;
        private System.Windows.Forms.Label labelSchedDescrip;
        private System.Windows.Forms.Button buttonAddAss;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelEventDescription;
        private System.Windows.Forms.Label labelDescriptionHeader;
        private System.Windows.Forms.ComboBox comboBoxFilters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox checkedListBoxAssignments;
        private System.Windows.Forms.Panel panelAddNew;
        private System.Windows.Forms.Button buttonAddFinish;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonResources;
        private System.Windows.Forms.Button buttonMessaging;
        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.Button buttonForum;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
    }
}