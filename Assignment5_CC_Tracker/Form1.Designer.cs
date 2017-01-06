namespace Assignment3_Vehicle_Tracker
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_interest = new System.Windows.Forms.Label();
            this.lbl_cardName = new System.Windows.Forms.Label();
            this.lbl_amt_owed = new System.Windows.Forms.Label();
            this.lbl_irate = new System.Windows.Forms.Label();
            this.lbl_cc_name = new System.Windows.Forms.Label();
            this.lbl_owed = new System.Windows.Forms.Label();
            this.lbl_int_rate = new System.Windows.Forms.Label();
            this.lbl_i_earned = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 212);
            this.listBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listBox1, "Displays file contents");
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(251, 21);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(94, 23);
            this.btn_Read.TabIndex = 1;
            this.btn_Read.Text = "Read File";
            this.toolTip1.SetToolTip(this.btn_Read, "Select File to Open");
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(251, 181);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(94, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Close Account";
            this.toolTip1.SetToolTip(this.btn_Close, "Close and delete the account");
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(251, 210);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(94, 23);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btn_Exit, "Exit Application");
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_interest
            // 
            this.lbl_interest.AutoSize = true;
            this.lbl_interest.Location = new System.Drawing.Point(16, 337);
            this.lbl_interest.Name = "lbl_interest";
            this.lbl_interest.Size = new System.Drawing.Size(51, 13);
            this.lbl_interest.TabIndex = 7;
            this.lbl_interest.Text = "$ Interest";
            this.toolTip1.SetToolTip(this.lbl_interest, "Interest earned.");
            // 
            // lbl_cardName
            // 
            this.lbl_cardName.AutoSize = true;
            this.lbl_cardName.Location = new System.Drawing.Point(16, 263);
            this.lbl_cardName.Name = "lbl_cardName";
            this.lbl_cardName.Size = new System.Drawing.Size(60, 13);
            this.lbl_cardName.TabIndex = 4;
            this.lbl_cardName.Text = "Card Name";
            // 
            // lbl_amt_owed
            // 
            this.lbl_amt_owed.AutoSize = true;
            this.lbl_amt_owed.Location = new System.Drawing.Point(16, 286);
            this.lbl_amt_owed.Name = "lbl_amt_owed";
            this.lbl_amt_owed.Size = new System.Drawing.Size(74, 13);
            this.lbl_amt_owed.TabIndex = 5;
            this.lbl_amt_owed.Text = "Amount Owed";
            // 
            // lbl_irate
            // 
            this.lbl_irate.AutoSize = true;
            this.lbl_irate.Location = new System.Drawing.Point(16, 313);
            this.lbl_irate.Name = "lbl_irate";
            this.lbl_irate.Size = new System.Drawing.Size(68, 13);
            this.lbl_irate.TabIndex = 6;
            this.lbl_irate.Text = "Interest Rate";
            // 
            // lbl_cc_name
            // 
            this.lbl_cc_name.AutoSize = true;
            this.lbl_cc_name.Location = new System.Drawing.Point(148, 263);
            this.lbl_cc_name.Name = "lbl_cc_name";
            this.lbl_cc_name.Size = new System.Drawing.Size(0, 13);
            this.lbl_cc_name.TabIndex = 8;
            // 
            // lbl_owed
            // 
            this.lbl_owed.AutoSize = true;
            this.lbl_owed.Location = new System.Drawing.Point(148, 286);
            this.lbl_owed.Name = "lbl_owed";
            this.lbl_owed.Size = new System.Drawing.Size(0, 13);
            this.lbl_owed.TabIndex = 9;
            // 
            // lbl_int_rate
            // 
            this.lbl_int_rate.AutoSize = true;
            this.lbl_int_rate.Location = new System.Drawing.Point(148, 313);
            this.lbl_int_rate.Name = "lbl_int_rate";
            this.lbl_int_rate.Size = new System.Drawing.Size(0, 13);
            this.lbl_int_rate.TabIndex = 10;
            // 
            // lbl_i_earned
            // 
            this.lbl_i_earned.AutoSize = true;
            this.lbl_i_earned.Location = new System.Drawing.Point(148, 337);
            this.lbl_i_earned.Name = "lbl_i_earned";
            this.lbl_i_earned.Size = new System.Drawing.Size(0, 13);
            this.lbl_i_earned.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 363);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(368, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            this.toolTip1.SetToolTip(this.statusStrip1, "Currently open file.");
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.ToolTipText = "Current open file.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 385);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbl_i_earned);
            this.Controls.Add(this.lbl_int_rate);
            this.Controls.Add(this.lbl_owed);
            this.Controls.Add(this.lbl_cc_name);
            this.Controls.Add(this.lbl_interest);
            this.Controls.Add(this.lbl_irate);
            this.Controls.Add(this.lbl_amt_owed);
            this.Controls.Add(this.lbl_cardName);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(384, 423);
            this.MinimumSize = new System.Drawing.Size(384, 423);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CC Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_cardName;
        private System.Windows.Forms.Label lbl_amt_owed;
        private System.Windows.Forms.Label lbl_irate;
        private System.Windows.Forms.Label lbl_cc_name;
        private System.Windows.Forms.Label lbl_owed;
        private System.Windows.Forms.Label lbl_int_rate;
        private System.Windows.Forms.Label lbl_i_earned;
        private System.Windows.Forms.Label lbl_interest;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

