using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment3_Vehicle_Tracker
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFD = new OpenFileDialog();
        List<string> data = new List<string>();

        public Form1()
        {
            InitializeComponent();
            btn_Close.Enabled = false;
            //   listBox1.Enabled = false;
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
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string pathinfo = openFD.FileName;
                    StreamReader sr = new StreamReader(pathinfo);

                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        // load the listbox just with the first field (CC Name)
                        // keep track of the whole line in list data
                        listBox1.Items.Add(line.Split(',')[0]);
                        data.Add(line);
                    }

                    sr.Close();
                    listBox1.Enabled = true;
                    btn_Read.Enabled = false;
                    btn_Close.Enabled = true;

                    string[] path_parts = pathinfo.Split(Path.DirectorySeparatorChar);
                    toolStripStatusLabel1.Text = "File: " + path_parts[path_parts.Length - 1];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // find out which index in the listbox was selected and use it
            // to retrieve the correct line from 'data' and parse/display
            // for some reason, idx == -1 sometimes if I clicked too soon, as
            // if the listbox wasn't ready. The if-statement takes care of this.
            int idx = listBox1.SelectedIndex;

            if (idx >= 0)
            {
                string[] parts = data[idx].Split(',');
                lbl_cc_name.Text = parts[0];
                double owed = Convert.ToDouble(parts[1]);
                double int_rate = Convert.ToDouble(parts[2]);
                double interest_earned = owed * int_rate / 100;

                lbl_owed.Text = string.Format("{0:C}", owed);
                lbl_int_rate.Text = string.Format("{0:N} %", int_rate);
                lbl_i_earned.Text = string.Format("{0:C}", interest_earned);
            }
            else
                MessageBox.Show("idx: " + idx);
        }
    }
}
