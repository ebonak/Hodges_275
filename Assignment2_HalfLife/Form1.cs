using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_HalfLife
{
    public partial class Form1 : Form
    {
        // initialize with default values
        private double init_amt = 100.0;
        private double curr_amt = 25.0;
        private double elapsed_time = 2.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_InitAmt.Text = init_amt.ToString();

            if (curr_amt > init_amt)
                curr_amt = init_amt;

            txt_CurrAmt.Text = curr_amt.ToString();

            if (elapsed_time < 0)
                elapsed_time = 0.0;

            txt_ElapsedTime.Text = elapsed_time.ToString();
        }


        // service code - compute the half-life
        private static double compute_HL(double init_amt, double curr_amt, double hl_time)
        {
            return (hl_time * Math.Log(2) / (Math.Log(init_amt / curr_amt)));
        }

        // ------------------- TEXT BOXES ---------------------------
        // TEXT - Initial Amount Changed
        private void txt_InitAmt_TextChanged(object sender, EventArgs e)
        {
            init_amt = Convert.ToDouble(txt_InitAmt.Text);
            lbl_HL_result.Text = "";
        }


        // TEXT - Current Amount Changed
        private void txt_CurrAmt_TextChanged(object sender, EventArgs e)
        {
            double tmp_curr_amt = Convert.ToDouble(txt_CurrAmt.Text);
            if (tmp_curr_amt <= init_amt)
                curr_amt = tmp_curr_amt;
            else
                txt_CurrAmt.Text = curr_amt.ToString();

            lbl_HL_result.Text = "";

        }

        // TEXT - Elapsed Time Changed
        private void txt_ElapsedTime_TextChanged(object sender, EventArgs e)
        {
            elapsed_time = Convert.ToDouble(txt_ElapsedTime.Text);
            lbl_HL_result.Text = "";
        }

        // ------------------- BUTTONS ------------------------------
        // BUTTON - compute the Half-Life
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            double hl = compute_HL(init_amt, curr_amt, elapsed_time);
            lbl_HL_result.Text = string.Format("Half-life is {0:F}", hl);
        }


        // BUTTON - reset defaults
        private void btn_Defaults_Click(object sender, EventArgs e)
        {
            txt_InitAmt.Text = "100";
            txt_CurrAmt.Text = "25";
            txt_ElapsedTime.Text = "2";
        }



        // BUTTON - Increase time
        private void btn_IncreaseTime_Click(object sender, EventArgs e)
        {
            double new_time = Convert.ToDouble(txt_ElapsedTime.Text) + 1;
            txt_ElapsedTime.Text = new_time.ToString();
        }

        // BUTTON - Decrease time
        private void btn_DecreaseTime_Click(object sender, EventArgs e)
        {
            double new_time = Convert.ToDouble(txt_ElapsedTime.Text) - 1;
            if (new_time < 0)
            {
                new_time = 0.0;
                // could do message box here too ..
            }

            txt_ElapsedTime.Text = new_time.ToString();
        }


        // BUTTON - EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
