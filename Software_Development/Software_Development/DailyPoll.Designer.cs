namespace Software_Development
{
    partial class DailyPoll
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.radioButtonChicken = new System.Windows.Forms.RadioButton();
            this.radioButtonBurger = new System.Windows.Forms.RadioButton();
            this.radioButtonNacho = new System.Windows.Forms.RadioButton();
            this.radioButtonPizza = new System.Windows.Forms.RadioButton();
            this.buttonVote = new System.Windows.Forms.Button();
            this.panelResults = new System.Windows.Forms.Panel();
            this.panelPoll = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.labelNuggetsRes = new System.Windows.Forms.Label();
            this.labelBurgersRes = new System.Windows.Forms.Label();
            this.labelNachoRes = new System.Windows.Forms.Label();
            this.labelPizzaRes = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.radioButtonInvis = new System.Windows.Forms.RadioButton();
            this.panelResults.SuspendLayout();
            this.panelPoll.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(13, 9);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(348, 17);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Which of the following cafeteria foods is your favorite?";
            // 
            // radioButtonChicken
            // 
            this.radioButtonChicken.AutoSize = true;
            this.radioButtonChicken.Location = new System.Drawing.Point(42, 51);
            this.radioButtonChicken.Name = "radioButtonChicken";
            this.radioButtonChicken.Size = new System.Drawing.Size(136, 21);
            this.radioButtonChicken.TabIndex = 1;
            this.radioButtonChicken.Text = "Chicken Nuggets";
            this.radioButtonChicken.UseVisualStyleBackColor = true;
            // 
            // radioButtonBurger
            // 
            this.radioButtonBurger.AutoSize = true;
            this.radioButtonBurger.Location = new System.Drawing.Point(42, 100);
            this.radioButtonBurger.Name = "radioButtonBurger";
            this.radioButtonBurger.Size = new System.Drawing.Size(126, 21);
            this.radioButtonBurger.TabIndex = 2;
            this.radioButtonBurger.Text = "Cheeseburgers";
            this.radioButtonBurger.UseVisualStyleBackColor = true;
            // 
            // radioButtonNacho
            // 
            this.radioButtonNacho.AutoSize = true;
            this.radioButtonNacho.Location = new System.Drawing.Point(42, 149);
            this.radioButtonNacho.Name = "radioButtonNacho";
            this.radioButtonNacho.Size = new System.Drawing.Size(77, 21);
            this.radioButtonNacho.TabIndex = 3;
            this.radioButtonNacho.Text = "Nachos";
            this.radioButtonNacho.UseVisualStyleBackColor = true;
            // 
            // radioButtonPizza
            // 
            this.radioButtonPizza.AutoSize = true;
            this.radioButtonPizza.Location = new System.Drawing.Point(42, 198);
            this.radioButtonPizza.Name = "radioButtonPizza";
            this.radioButtonPizza.Size = new System.Drawing.Size(63, 21);
            this.radioButtonPizza.TabIndex = 4;
            this.radioButtonPizza.Text = "Pizza";
            this.radioButtonPizza.UseVisualStyleBackColor = true;
            // 
            // buttonVote
            // 
            this.buttonVote.Location = new System.Drawing.Point(199, 253);
            this.buttonVote.Name = "buttonVote";
            this.buttonVote.Size = new System.Drawing.Size(162, 54);
            this.buttonVote.TabIndex = 6;
            this.buttonVote.Text = "Vote!";
            this.buttonVote.UseVisualStyleBackColor = true;
            this.buttonVote.Click += new System.EventHandler(this.buttonVote_Click);
            // 
            // panelResults
            // 
            this.panelResults.Controls.Add(this.buttonClose);
            this.panelResults.Controls.Add(this.labelPizzaRes);
            this.panelResults.Controls.Add(this.labelNachoRes);
            this.panelResults.Controls.Add(this.labelBurgersRes);
            this.panelResults.Controls.Add(this.labelNuggetsRes);
            this.panelResults.Controls.Add(this.labelResults);
            this.panelResults.Controls.Add(this.labelHeader);
            this.panelResults.Location = new System.Drawing.Point(20, 20);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(401, 338);
            this.panelResults.TabIndex = 7;
            // 
            // panelPoll
            // 
            this.panelPoll.Controls.Add(this.radioButtonInvis);
            this.panelPoll.Controls.Add(this.buttonVote);
            this.panelPoll.Controls.Add(this.radioButtonPizza);
            this.panelPoll.Controls.Add(this.radioButtonNacho);
            this.panelPoll.Controls.Add(this.radioButtonBurger);
            this.panelPoll.Controls.Add(this.radioButtonChicken);
            this.panelPoll.Controls.Add(this.labelQuestion);
            this.panelPoll.Location = new System.Drawing.Point(20, 20);
            this.panelPoll.Name = "panelPoll";
            this.panelPoll.Size = new System.Drawing.Size(406, 334);
            this.panelPoll.TabIndex = 7;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(17, 30);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(348, 17);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Which of the following cafeteria foods is your favorite?";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(17, 73);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(156, 17);
            this.labelResults.TabIndex = 2;
            this.labelResults.Text = "Total results: 200 votes";
            // 
            // labelNuggetsRes
            // 
            this.labelNuggetsRes.AutoSize = true;
            this.labelNuggetsRes.Location = new System.Drawing.Point(17, 119);
            this.labelNuggetsRes.Name = "labelNuggetsRes";
            this.labelNuggetsRes.Size = new System.Drawing.Size(231, 17);
            this.labelNuggetsRes.TabIndex = 3;
            this.labelNuggetsRes.Text = "Chicken Nuggets: 68 votes (37.0%)";
            // 
            // labelBurgersRes
            // 
            this.labelBurgersRes.AutoSize = true;
            this.labelBurgersRes.Location = new System.Drawing.Point(17, 172);
            this.labelBurgersRes.Name = "labelBurgersRes";
            this.labelBurgersRes.Size = new System.Drawing.Size(213, 17);
            this.labelBurgersRes.TabIndex = 4;
            this.labelBurgersRes.Text = "Cheeseburgers: 19 votes (9.5%)";
            // 
            // labelNachoRes
            // 
            this.labelNachoRes.AutoSize = true;
            this.labelNachoRes.Location = new System.Drawing.Point(17, 225);
            this.labelNachoRes.Name = "labelNachoRes";
            this.labelNachoRes.Size = new System.Drawing.Size(172, 17);
            this.labelNachoRes.TabIndex = 5;
            this.labelNachoRes.Text = "Nachos: 98 votes (49.0%)";
            // 
            // labelPizzaRes
            // 
            this.labelPizzaRes.AutoSize = true;
            this.labelPizzaRes.Location = new System.Drawing.Point(17, 278);
            this.labelPizzaRes.Name = "labelPizzaRes";
            this.labelPizzaRes.Size = new System.Drawing.Size(150, 17);
            this.labelPizzaRes.TabIndex = 6;
            this.labelPizzaRes.Text = "Pizza: 15 votes (7.5%)";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(225, 278);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(162, 44);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // radioButtonInvis
            // 
            this.radioButtonInvis.AutoSize = true;
            this.radioButtonInvis.Checked = true;
            this.radioButtonInvis.Location = new System.Drawing.Point(229, 95);
            this.radioButtonInvis.Name = "radioButtonInvis";
            this.radioButtonInvis.Size = new System.Drawing.Size(158, 21);
            this.radioButtonInvis.TabIndex = 7;
            this.radioButtonInvis.TabStop = true;
            this.radioButtonInvis.Text = "this doesn\'t exist btw";
            this.radioButtonInvis.UseVisualStyleBackColor = true;
            // 
            // DailyPoll
            // 
            this.AcceptButton = this.buttonVote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 386);
            this.Controls.Add(this.panelPoll);
            this.Controls.Add(this.panelResults);
            this.Name = "DailyPoll";
            this.Text = "Daily Poll";
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            this.panelPoll.ResumeLayout(false);
            this.panelPoll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.RadioButton radioButtonChicken;
        private System.Windows.Forms.RadioButton radioButtonBurger;
        private System.Windows.Forms.RadioButton radioButtonNacho;
        private System.Windows.Forms.RadioButton radioButtonPizza;
        private System.Windows.Forms.Button buttonVote;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Panel panelPoll;
        private System.Windows.Forms.Label labelPizzaRes;
        private System.Windows.Forms.Label labelNachoRes;
        private System.Windows.Forms.Label labelBurgersRes;
        private System.Windows.Forms.Label labelNuggetsRes;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.RadioButton radioButtonInvis;
    }
}