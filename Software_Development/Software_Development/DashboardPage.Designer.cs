﻿namespace Software_Development
{
    partial class DashboardPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPage));
            this.buttonPoll = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.labelProfile = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonResources = new System.Windows.Forms.Button();
            this.buttonMessaging = new System.Windows.Forms.Button();
            this.buttonForum = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPoll
            // 
            this.buttonPoll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPoll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.buttonPoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPoll.Font = new System.Drawing.Font("Segoe UI Light", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoll.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonPoll.Location = new System.Drawing.Point(284, 474);
            this.buttonPoll.Name = "buttonPoll";
            this.buttonPoll.Size = new System.Drawing.Size(135, 50);
            this.buttonPoll.TabIndex = 31;
            this.buttonPoll.Text = "Daily Poll";
            this.buttonPoll.UseVisualStyleBackColor = false;
            this.buttonPoll.Click += new System.EventHandler(this.buttonPoll_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.pictureBoxMinimize);
            this.panelHeader.Controls.Add(this.pictureBoxLogout);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.pictureBoxClose);
            this.panelHeader.Location = new System.Drawing.Point(173, -2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(792, 67);
            this.panelHeader.TabIndex = 29;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // pictureBoxLogout
            // 
            this.pictureBoxLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogout.Image = global::Software_Development.Properties.Resources.logout;
            this.pictureBoxLogout.Location = new System.Drawing.Point(729, 1);
            this.pictureBoxLogout.Name = "pictureBoxLogout";
            this.pictureBoxLogout.Size = new System.Drawing.Size(30, 35);
            this.pictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogout.TabIndex = 25;
            this.pictureBoxLogout.TabStop = false;
            this.pictureBoxLogout.Click += new System.EventHandler(this.pictureBoxLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dashboard";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::Software_Development.Properties.Resources.xicon;
            this.pictureBoxClose.Location = new System.Drawing.Point(760, 8);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(21, 22);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 24;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panelProfile.Controls.Add(this.labelProfile);
            this.panelProfile.Controls.Add(this.pictureBoxProfile);
            this.panelProfile.Location = new System.Drawing.Point(-1, -2);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(174, 67);
            this.panelProfile.TabIndex = 28;
            this.panelProfile.Click += new System.EventHandler(this.panel2_Click);
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelProfile.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.ForeColor = System.Drawing.Color.White;
            this.labelProfile.Location = new System.Drawing.Point(69, 24);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(83, 19);
            this.labelProfile.TabIndex = 1;
            this.labelProfile.Text = "My Account";
            this.labelProfile.Click += new System.EventHandler(this.labelProfile_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxProfile.Image = global::Software_Development.Properties.Resources.robot;
            this.pictureBoxProfile.Location = new System.Drawing.Point(27, 14);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(39, 39);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.buttonResources);
            this.panel1.Controls.Add(this.buttonMessaging);
            this.panel1.Controls.Add(this.buttonForum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonCalendar);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Location = new System.Drawing.Point(-1, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 475);
            this.panel1.TabIndex = 27;
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
            this.buttonResources.Location = new System.Drawing.Point(0, 288);
            this.buttonResources.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.buttonResources.Name = "buttonResources";
            this.buttonResources.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonResources.Size = new System.Drawing.Size(174, 72);
            this.buttonResources.TabIndex = 30;
            this.buttonResources.Text = "  Resources";
            this.buttonResources.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonResources.UseVisualStyleBackColor = false;
            this.buttonResources.Click += new System.EventHandler(this.buttonResources_Click);
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
            this.buttonMessaging.Location = new System.Drawing.Point(0, 216);
            this.buttonMessaging.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.buttonMessaging.Name = "buttonMessaging";
            this.buttonMessaging.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonMessaging.Size = new System.Drawing.Size(174, 72);
            this.buttonMessaging.TabIndex = 29;
            this.buttonMessaging.Text = "  Messaging";
            this.buttonMessaging.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMessaging.UseVisualStyleBackColor = false;
            this.buttonMessaging.Click += new System.EventHandler(this.buttonMessaging_Click);
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
            this.buttonForum.Location = new System.Drawing.Point(0, 144);
            this.buttonForum.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.buttonForum.Name = "buttonForum";
            this.buttonForum.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonForum.Size = new System.Drawing.Size(174, 72);
            this.buttonForum.TabIndex = 28;
            this.buttonForum.Text = "  Forum";
            this.buttonForum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonForum.UseVisualStyleBackColor = false;
            this.buttonForum.Click += new System.EventHandler(this.buttonForum_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 45);
            this.label3.TabIndex = 27;
            this.label3.Text = "Edutalk";
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonCalendar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonCalendar.FlatAppearance.BorderSize = 0;
            this.buttonCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalendar.Font = new System.Drawing.Font("Segoe UI Semilight", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalendar.ForeColor = System.Drawing.Color.White;
            this.buttonCalendar.Image = global::Software_Development.Properties.Resources.calendar;
            this.buttonCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalendar.Location = new System.Drawing.Point(0, 72);
            this.buttonCalendar.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonCalendar.Size = new System.Drawing.Size(174, 72);
            this.buttonCalendar.TabIndex = 1;
            this.buttonCalendar.Text = "  Calendar";
            this.buttonCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCalendar.UseVisualStyleBackColor = false;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI Semilight", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(174, 72);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "  Home";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            this.buttonHome.MouseHover += new System.EventHandler(this.buttonHome_MouseHover);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(415, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(502, 256);
            this.panel4.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 105);
            this.label5.TabIndex = 27;
            this.label5.Text = "Hey Hawks, hope everyone is having a great week!\r\nImportant News:\r\n- Orchestra Co" +
    "ncert coming up\r\n- Spring sports - Athletic Meeting for Parents\r\n- Volunteer for" +
    " the book fair this week!\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 22.25455F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 47);
            this.label4.TabIndex = 26;
            this.label4.Text = "School Update:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(497, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 50);
            this.button1.TabIndex = 80;
            this.button1.Text = "Forum";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonForum_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SteelBlue;
            this.button2.Location = new System.Drawing.Point(705, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 50);
            this.button2.TabIndex = 82;
            this.button2.Text = "Messages";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(223, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(196, 256);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 83;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Software_Development.Properties.Resources.icons8_speech_bubble_100;
            this.pictureBox5.Location = new System.Drawing.Point(717, 353);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(109, 102);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 81;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Software_Development.Properties.Resources.icons8_user_account_filled_100;
            this.pictureBox4.Location = new System.Drawing.Point(509, 353);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 102);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 79;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Software_Development.Properties.Resources.icons8_poll_filled_100;
            this.pictureBox2.Location = new System.Drawing.Point(298, 353);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimize.Image = global::Software_Development.Properties.Resources.substract;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(708, 15);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(19, 21);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimize.TabIndex = 84;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // DashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(964, 539);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.buttonPoll);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelProfile);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dashboard_FormClosing);
            this.Load += new System.EventHandler(this.DashboardPage_Shown);
            this.Shown += new System.EventHandler(this.DashboardPage_Shown);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonPoll;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.PictureBox pictureBoxLogout;
        private System.Windows.Forms.Button buttonResources;
        private System.Windows.Forms.Button buttonMessaging;
        private System.Windows.Forms.Button buttonForum;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
    }
}