namespace WFA2_19621609
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
            this.btmCheck = new System.Windows.Forms.Button();
            this.txtEnterNumber = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblGuessed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmCheck
            // 
            this.btmCheck.Location = new System.Drawing.Point(48, 120);
            this.btmCheck.Name = "btmCheck";
            this.btmCheck.Size = new System.Drawing.Size(210, 47);
            this.btmCheck.TabIndex = 0;
            this.btmCheck.Text = "Check";
            this.btmCheck.UseVisualStyleBackColor = true;
            this.btmCheck.Click += new System.EventHandler(this.btmCheck_Click);
            // 
            // txtEnterNumber
            // 
            this.txtEnterNumber.Location = new System.Drawing.Point(44, 67);
            this.txtEnterNumber.Name = "txtEnterNumber";
            this.txtEnterNumber.Size = new System.Drawing.Size(227, 20);
            this.txtEnterNumber.TabIndex = 1;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(39, 29);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(170, 13);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "I am thinking of a number between";
            // 
            // lblGuessed
            // 
            this.lblGuessed.AutoSize = true;
            this.lblGuessed.Location = new System.Drawing.Point(39, 227);
            this.lblGuessed.Name = "lblGuessed";
            this.lblGuessed.Size = new System.Drawing.Size(105, 13);
            this.lblGuessed.TabIndex = 3;
            this.lblGuessed.Text = "You guessed 0 times";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 303);
            this.Controls.Add(this.lblGuessed);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtEnterNumber);
            this.Controls.Add(this.btmCheck);
            this.Name = "Form1";
            this.Text = "Number guessing game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmCheck;
        private System.Windows.Forms.TextBox txtEnterNumber;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblGuessed;
    }
}

