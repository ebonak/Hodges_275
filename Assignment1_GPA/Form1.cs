using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hodges_275
{
    public partial class Form1 : Form
    {
        private string name = "";
        private double gpa = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            name = txtFirstName.Text;
        }

        private void txtGPA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                gpa = Convert.ToDouble(txtGPA.Text);
                if ((gpa < 0) || (gpa > 4))
                {
                    MessageBox.Show("invalid gpa " + gpa, "INVALID", MessageBoxButtons.OK);
                    txtGPA.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem with GPA, try again " + name);
                txtGPA.Clear();
            }
        }

        private void btnHonors_Click(object sender, EventArgs e)
        {
            if (gpa > 3.75)
                lblMessage.Text = "HONOR STUDENT";
            else
            {
                lblMessage.Text = "";
                MessageBox.Show("Not quite yet a Honor Student");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
        }
    }
}
