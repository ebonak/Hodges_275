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
        private double init_amt = 0.0;
        private double cur_amt = 0.0;
        private double hl_time = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // compute the half-life
        private static double compute_HL(double init_amt, double cur_amt, double hl_time)
        {
            double half_life = 0.0;

            half_life = (Math.Log(hl_time, 2) / (Math.Log(init_amt/cur_amt)));

            return half_life;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
