using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_Vehicle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.InitialDirectory = Application.StartupPath;
            // openFD.InitialDirectory = ".";

            if (openFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string pathinfo = openFD.FileName;
                MessageBox.Show(pathinfo);
            }
        }
    }
}
