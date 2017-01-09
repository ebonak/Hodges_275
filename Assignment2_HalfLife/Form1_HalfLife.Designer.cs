namespace Assignment2_HalfLife
{
    partial class Form1_HalfLife
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
            this.lbl_Init_Amount = new System.Windows.Forms.Label();
            this.lbl_CurAmount = new System.Windows.Forms.Label();
            this.lbl_ElapsedTime = new System.Windows.Forms.Label();
            this.txt_InitAmt = new System.Windows.Forms.TextBox();
            this.txt_ElapsedTime = new System.Windows.Forms.TextBox();
            this.txt_CurrAmt = new System.Windows.Forms.TextBox();
            this.btn_IncreaseTime = new System.Windows.Forms.Button();
            this.btn_DecreaseTime = new System.Windows.Forms.Button();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Defaults = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_HL_result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Init_Amount
            // 
            this.lbl_Init_Amount.AutoSize = true;
            this.lbl_Init_Amount.Location = new System.Drawing.Point(12, 65);
            this.lbl_Init_Amount.Name = "lbl_Init_Amount";
            this.lbl_Init_Amount.Size = new System.Drawing.Size(70, 13);
            this.lbl_Init_Amount.TabIndex = 0;
            this.lbl_Init_Amount.Text = "Initial Amount";
            // 
            // lbl_CurAmount
            // 
            this.lbl_CurAmount.AutoSize = true;
            this.lbl_CurAmount.Location = new System.Drawing.Point(12, 119);
            this.lbl_CurAmount.Name = "lbl_CurAmount";
            this.lbl_CurAmount.Size = new System.Drawing.Size(83, 13);
            this.lbl_CurAmount.TabIndex = 1;
            this.lbl_CurAmount.Text = "Current Amount ";
            // 
            // lbl_ElapsedTime
            // 
            this.lbl_ElapsedTime.AutoSize = true;
            this.lbl_ElapsedTime.Location = new System.Drawing.Point(12, 179);
            this.lbl_ElapsedTime.Name = "lbl_ElapsedTime";
            this.lbl_ElapsedTime.Size = new System.Drawing.Size(71, 13);
            this.lbl_ElapsedTime.TabIndex = 2;
            this.lbl_ElapsedTime.Text = "Elapsed Time";
            // 
            // txt_InitAmt
            // 
            this.txt_InitAmt.Location = new System.Drawing.Point(101, 62);
            this.txt_InitAmt.Name = "txt_InitAmt";
            this.txt_InitAmt.Size = new System.Drawing.Size(60, 20);
            this.txt_InitAmt.TabIndex = 3;
            this.txt_InitAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_InitAmt.TextChanged += new System.EventHandler(this.txt_InitAmt_TextChanged);
            // 
            // txt_ElapsedTime
            // 
            this.txt_ElapsedTime.Location = new System.Drawing.Point(101, 176);
            this.txt_ElapsedTime.Name = "txt_ElapsedTime";
            this.txt_ElapsedTime.Size = new System.Drawing.Size(60, 20);
            this.txt_ElapsedTime.TabIndex = 5;
            this.txt_ElapsedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ElapsedTime.TextChanged += new System.EventHandler(this.txt_ElapsedTime_TextChanged);
            // 
            // txt_CurrAmt
            // 
            this.txt_CurrAmt.Location = new System.Drawing.Point(101, 116);
            this.txt_CurrAmt.Name = "txt_CurrAmt";
            this.txt_CurrAmt.Size = new System.Drawing.Size(60, 20);
            this.txt_CurrAmt.TabIndex = 4;
            this.txt_CurrAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_CurrAmt.TextChanged += new System.EventHandler(this.txt_CurrAmt_TextChanged);
            // 
            // btn_IncreaseTime
            // 
            this.btn_IncreaseTime.Location = new System.Drawing.Point(229, 85);
            this.btn_IncreaseTime.Name = "btn_IncreaseTime";
            this.btn_IncreaseTime.Size = new System.Drawing.Size(95, 23);
            this.btn_IncreaseTime.TabIndex = 7;
            this.btn_IncreaseTime.Text = "Increase Time";
            this.btn_IncreaseTime.UseVisualStyleBackColor = true;
            this.btn_IncreaseTime.Click += new System.EventHandler(this.btn_IncreaseTime_Click);
            // 
            // btn_DecreaseTime
            // 
            this.btn_DecreaseTime.Location = new System.Drawing.Point(229, 129);
            this.btn_DecreaseTime.Name = "btn_DecreaseTime";
            this.btn_DecreaseTime.Size = new System.Drawing.Size(95, 23);
            this.btn_DecreaseTime.TabIndex = 8;
            this.btn_DecreaseTime.Text = "Decrease Time";
            this.btn_DecreaseTime.UseVisualStyleBackColor = true;
            this.btn_DecreaseTime.Click += new System.EventHandler(this.btn_DecreaseTime_Click);
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(50, 218);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(111, 23);
            this.btn_Calculate.TabIndex = 6;
            this.btn_Calculate.Text = "Calculate Half-Life";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Defaults
            // 
            this.btn_Defaults.Location = new System.Drawing.Point(177, 218);
            this.btn_Defaults.Name = "btn_Defaults";
            this.btn_Defaults.Size = new System.Drawing.Size(111, 23);
            this.btn_Defaults.TabIndex = 9;
            this.btn_Defaults.Text = "Reset Defaults";
            this.btn_Defaults.UseVisualStyleBackColor = true;
            this.btn_Defaults.Click += new System.EventHandler(this.btn_Defaults_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 59);
            this.label1.TabIndex = 10;
            this.label1.Text = "Half-Life Calculator";
            // 
            // lbl_HL_result
            // 
            this.lbl_HL_result.AutoSize = true;
            this.lbl_HL_result.Location = new System.Drawing.Point(15, 263);
            this.lbl_HL_result.Name = "lbl_HL_result";
            this.lbl_HL_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_HL_result.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Esmail Bonakdarian";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(143, 258);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 22);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 288);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_HL_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Defaults);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.btn_DecreaseTime);
            this.Controls.Add(this.btn_IncreaseTime);
            this.Controls.Add(this.txt_CurrAmt);
            this.Controls.Add(this.txt_ElapsedTime);
            this.Controls.Add(this.txt_InitAmt);
            this.Controls.Add(this.lbl_ElapsedTime);
            this.Controls.Add(this.lbl_CurAmount);
            this.Controls.Add(this.lbl_Init_Amount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(352, 326);
            this.MinimumSize = new System.Drawing.Size(352, 326);
            this.Name = "Form1";
            this.Text = "Half-Life Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Init_Amount;
        private System.Windows.Forms.Label lbl_CurAmount;
        private System.Windows.Forms.Label lbl_ElapsedTime;
        private System.Windows.Forms.TextBox txt_InitAmt;
        private System.Windows.Forms.TextBox txt_ElapsedTime;
        private System.Windows.Forms.TextBox txt_CurrAmt;
        private System.Windows.Forms.Button btn_IncreaseTime;
        private System.Windows.Forms.Button btn_DecreaseTime;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Defaults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_HL_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
    }
}

