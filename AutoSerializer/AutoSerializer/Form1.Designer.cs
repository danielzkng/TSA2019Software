namespace AutoSerializer
{
    partial class Form1
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
            this.buttonReserialize = new System.Windows.Forms.Button();
            this.buttonDeserialize = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonUsers = new System.Windows.Forms.RadioButton();
            this.radioButtonEvents = new System.Windows.Forms.RadioButton();
            this.radioButtonCalendars = new System.Windows.Forms.RadioButton();
            this.radioButtonThreads = new System.Windows.Forms.RadioButton();
            this.radioButtonMessages = new System.Windows.Forms.RadioButton();
            this.radioButtonPrivateMessages = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReserialize
            // 
            this.buttonReserialize.Location = new System.Drawing.Point(49, 27);
            this.buttonReserialize.Name = "buttonReserialize";
            this.buttonReserialize.Size = new System.Drawing.Size(449, 152);
            this.buttonReserialize.TabIndex = 0;
            this.buttonReserialize.Text = "RESERIALIZE DATA";
            this.buttonReserialize.UseVisualStyleBackColor = true;
            this.buttonReserialize.Click += new System.EventHandler(this.buttonReserialize_Click);
            // 
            // buttonDeserialize
            // 
            this.buttonDeserialize.Location = new System.Drawing.Point(49, 217);
            this.buttonDeserialize.Name = "buttonDeserialize";
            this.buttonDeserialize.Size = new System.Drawing.Size(449, 152);
            this.buttonDeserialize.TabIndex = 1;
            this.buttonDeserialize.Text = "DESERIALIZE DATA";
            this.buttonDeserialize.UseVisualStyleBackColor = true;
            this.buttonDeserialize.Click += new System.EventHandler(this.buttonDeserialize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPrivateMessages);
            this.groupBox1.Controls.Add(this.radioButtonMessages);
            this.groupBox1.Controls.Add(this.radioButtonThreads);
            this.groupBox1.Controls.Add(this.radioButtonCalendars);
            this.groupBox1.Controls.Add(this.radioButtonEvents);
            this.groupBox1.Controls.Add(this.radioButtonUsers);
            this.groupBox1.Location = new System.Drawing.Point(532, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 342);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick File to Serialize";
            // 
            // radioButtonUsers
            // 
            this.radioButtonUsers.AutoSize = true;
            this.radioButtonUsers.Location = new System.Drawing.Point(27, 50);
            this.radioButtonUsers.Name = "radioButtonUsers";
            this.radioButtonUsers.Size = new System.Drawing.Size(84, 21);
            this.radioButtonUsers.TabIndex = 0;
            this.radioButtonUsers.TabStop = true;
            this.radioButtonUsers.Text = "users.db";
            this.radioButtonUsers.UseVisualStyleBackColor = true;
            // 
            // radioButtonEvents
            // 
            this.radioButtonEvents.AutoSize = true;
            this.radioButtonEvents.Location = new System.Drawing.Point(27, 96);
            this.radioButtonEvents.Name = "radioButtonEvents";
            this.radioButtonEvents.Size = new System.Drawing.Size(91, 21);
            this.radioButtonEvents.TabIndex = 1;
            this.radioButtonEvents.TabStop = true;
            this.radioButtonEvents.Text = "events.db";
            this.radioButtonEvents.UseVisualStyleBackColor = true;
            // 
            // radioButtonCalendars
            // 
            this.radioButtonCalendars.AutoSize = true;
            this.radioButtonCalendars.Location = new System.Drawing.Point(27, 142);
            this.radioButtonCalendars.Name = "radioButtonCalendars";
            this.radioButtonCalendars.Size = new System.Drawing.Size(111, 21);
            this.radioButtonCalendars.TabIndex = 2;
            this.radioButtonCalendars.TabStop = true;
            this.radioButtonCalendars.Text = "calendars.db";
            this.radioButtonCalendars.UseVisualStyleBackColor = true;
            // 
            // radioButtonThreads
            // 
            this.radioButtonThreads.AutoSize = true;
            this.radioButtonThreads.Location = new System.Drawing.Point(27, 188);
            this.radioButtonThreads.Name = "radioButtonThreads";
            this.radioButtonThreads.Size = new System.Drawing.Size(97, 21);
            this.radioButtonThreads.TabIndex = 3;
            this.radioButtonThreads.TabStop = true;
            this.radioButtonThreads.Text = "threads.db";
            this.radioButtonThreads.UseVisualStyleBackColor = true;
            // 
            // radioButtonMessages
            // 
            this.radioButtonMessages.AutoSize = true;
            this.radioButtonMessages.Location = new System.Drawing.Point(27, 234);
            this.radioButtonMessages.Name = "radioButtonMessages";
            this.radioButtonMessages.Size = new System.Drawing.Size(113, 21);
            this.radioButtonMessages.TabIndex = 4;
            this.radioButtonMessages.TabStop = true;
            this.radioButtonMessages.Text = "messages.db";
            this.radioButtonMessages.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrivateMessages
            // 
            this.radioButtonPrivateMessages.AutoSize = true;
            this.radioButtonPrivateMessages.Location = new System.Drawing.Point(27, 280);
            this.radioButtonPrivateMessages.Name = "radioButtonPrivateMessages";
            this.radioButtonPrivateMessages.Size = new System.Drawing.Size(125, 21);
            this.radioButtonPrivateMessages.TabIndex = 5;
            this.radioButtonPrivateMessages.TabStop = true;
            this.radioButtonPrivateMessages.Text = "privatemsgs.db";
            this.radioButtonPrivateMessages.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "directions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDeserialize);
            this.Controls.Add(this.buttonReserialize);
            this.Name = "Form1";
            this.Text = "Daniel Ng\'s Automagic Serializer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReserialize;
        private System.Windows.Forms.Button buttonDeserialize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPrivateMessages;
        private System.Windows.Forms.RadioButton radioButtonMessages;
        private System.Windows.Forms.RadioButton radioButtonThreads;
        private System.Windows.Forms.RadioButton radioButtonCalendars;
        private System.Windows.Forms.RadioButton radioButtonEvents;
        private System.Windows.Forms.RadioButton radioButtonUsers;
        private System.Windows.Forms.Button button1;
    }
}

