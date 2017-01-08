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
    public partial class Form1_Veh_Tracker : Form
    {
        const string input_filename = "vehicle_info.txt";
        List<string> data = new List<string>();


        public Form1_Veh_Tracker()
        {
            InitializeComponent();
        }


        private void Form1_Veh_Tracker_Load(object sender, EventArgs e)
        {
            // read the input file
            StreamReader sr = new StreamReader(input_filename);

            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                data.Add(line);
            }
            sr.Close();

            string stat_msg = String.Format("Read {0} lines from file '{1}'",
                                             data.Count, input_filename);
            toolStripStatusLabel1.Text = stat_msg;
            //MessageBox.Show(stat_msg);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
