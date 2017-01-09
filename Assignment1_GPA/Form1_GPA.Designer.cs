namespace Hodges_275
{
    partial class Form1_GPA
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblProgrammerName = new System.Windows.Forms.Label();
            this.btnHonors = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "GPA";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(89, 32);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(89, 63);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(100, 20);
            this.txtGPA.TabIndex = 3;
            this.txtGPA.TextChanged += new System.EventHandler(this.txtGPA_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(195, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "label3";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(86, 119);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(83, 13);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "No message yet";
            // 
            // lblProgrammerName
            // 
            this.lblProgrammerName.AutoSize = true;
            this.lblProgrammerName.Location = new System.Drawing.Point(172, 240);
            this.lblProgrammerName.Name = "lblProgrammerName";
            this.lblProgrammerName.Size = new System.Drawing.Size(100, 13);
            this.lblProgrammerName.TabIndex = 6;
            this.lblProgrammerName.Text = "Esmail Bonakdarian";
            // 
            // btnHonors
            // 
            this.btnHonors.Location = new System.Drawing.Point(31, 161);
            this.btnHonors.Name = "btnHonors";
            this.btnHonors.Size = new System.Drawing.Size(101, 23);
            this.btnHonors.TabIndex = 7;
            this.btnHonors.Text = "Honors Student?";
            this.btnHonors.UseVisualStyleBackColor = true;
            this.btnHonors.Click += new System.EventHandler(this.btnHonors_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(188, 161);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHonors);
            this.Controls.Add(this.lblProgrammerName);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblProgrammerName;
        private System.Windows.Forms.Button btnHonors;
        private System.Windows.Forms.Button btnExit;
    }
}

