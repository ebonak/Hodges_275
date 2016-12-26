namespace Assignment2_HalfLife
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
            this.lbl_Init_Amount = new System.Windows.Forms.Label();
            this.lbl_CurAmount = new System.Windows.Forms.Label();
            this.lbl_ElapsedTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_IncreaseTime = new System.Windows.Forms.Button();
            this.btn_DecreaseTime = new System.Windows.Forms.Button();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Defaults = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Half_Life = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lbl_CurAmount.Size = new System.Drawing.Size(80, 13);
            this.lbl_CurAmount.TabIndex = 1;
            this.lbl_CurAmount.Text = "Current Amount";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btn_IncreaseTime
            // 
            this.btn_IncreaseTime.Location = new System.Drawing.Point(229, 85);
            this.btn_IncreaseTime.Name = "btn_IncreaseTime";
            this.btn_IncreaseTime.Size = new System.Drawing.Size(95, 23);
            this.btn_IncreaseTime.TabIndex = 6;
            this.btn_IncreaseTime.Text = "Increase Time";
            this.btn_IncreaseTime.UseVisualStyleBackColor = true;
            // 
            // btn_DecreaseTime
            // 
            this.btn_DecreaseTime.Location = new System.Drawing.Point(229, 129);
            this.btn_DecreaseTime.Name = "btn_DecreaseTime";
            this.btn_DecreaseTime.Size = new System.Drawing.Size(95, 23);
            this.btn_DecreaseTime.TabIndex = 7;
            this.btn_DecreaseTime.Text = "Decrease Time";
            this.btn_DecreaseTime.UseVisualStyleBackColor = true;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(50, 218);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(111, 23);
            this.btn_Calculate.TabIndex = 8;
            this.btn_Calculate.Text = "Calculate Half-Life";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            // 
            // btn_Defaults
            // 
            this.btn_Defaults.Location = new System.Drawing.Point(177, 218);
            this.btn_Defaults.Name = "btn_Defaults";
            this.btn_Defaults.Size = new System.Drawing.Size(111, 23);
            this.btn_Defaults.TabIndex = 9;
            this.btn_Defaults.Text = "Reset Defaults";
            this.btn_Defaults.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Half-Life Calculator";
            // 
            // lbl_Half_Life
            // 
            this.lbl_Half_Life.AutoSize = true;
            this.lbl_Half_Life.Location = new System.Drawing.Point(15, 263);
            this.lbl_Half_Life.Name = "lbl_Half_Life";
            this.lbl_Half_Life.Size = new System.Drawing.Size(52, 13);
            this.lbl_Half_Life.TabIndex = 11;
            this.lbl_Half_Life.Text = "Half-life is";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 288);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Half_Life);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Defaults);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.btn_DecreaseTime);
            this.Controls.Add(this.btn_IncreaseTime);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_ElapsedTime);
            this.Controls.Add(this.lbl_CurAmount);
            this.Controls.Add(this.lbl_Init_Amount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Init_Amount;
        private System.Windows.Forms.Label lbl_CurAmount;
        private System.Windows.Forms.Label lbl_ElapsedTime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_IncreaseTime;
        private System.Windows.Forms.Button btn_DecreaseTime;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Defaults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Half_Life;
        private System.Windows.Forms.Label label2;
    }
}

