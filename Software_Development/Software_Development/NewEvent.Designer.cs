namespace Software_Development
{
    partial class NewEvent
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
            this.monthCalendarDate = new System.Windows.Forms.MonthCalendar();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelInCal = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescrip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendarDate
            // 
            this.monthCalendarDate.Location = new System.Drawing.Point(77, 16);
            this.monthCalendarDate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendarDate.MaxSelectionCount = 1;
            this.monthCalendarDate.Name = "monthCalendarDate";
            this.monthCalendarDate.TabIndex = 0;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI Semilight", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(21, 16);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(40, 19);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semilight", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(37, 238);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(48, 19);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(135, 237);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(170, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelInCal
            // 
            this.labelInCal.AutoSize = true;
            this.labelInCal.Font = new System.Drawing.Font("Segoe UI Semilight", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInCal.Location = new System.Drawing.Point(37, 302);
            this.labelInCal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInCal.Name = "labelInCal";
            this.labelInCal.Size = new System.Drawing.Size(82, 19);
            this.labelInCal.TabIndex = 4;
            this.labelInCal.Text = "In Calendar:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 303);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(210, 346);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(92, 34);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(40, 346);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 34);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(135, 270);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(170, 20);
            this.textBoxDescription.TabIndex = 9;
            // 
            // labelDescrip
            // 
            this.labelDescrip.AutoSize = true;
            this.labelDescrip.Font = new System.Drawing.Font("Segoe UI Semilight", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescrip.Location = new System.Drawing.Point(37, 271);
            this.labelDescrip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescrip.Name = "labelDescrip";
            this.labelDescrip.Size = new System.Drawing.Size(80, 19);
            this.labelDescrip.TabIndex = 8;
            this.labelDescrip.Text = "Description:";
            // 
            // NewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 409);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescrip);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelInCal);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.monthCalendarDate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewEvent";
            this.Text = "Add Event";
            this.Load += new System.EventHandler(this.NewEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelInCal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescrip;
    }
}