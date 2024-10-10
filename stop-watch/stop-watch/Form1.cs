using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stop_watch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int msecs = Convert.ToInt32(mseclb.Text);
            int secs = Convert.ToInt32(seclb.Text);
            int mins = Convert.ToInt32(minlb.Text);
            int hrs = Convert.ToInt32(hrslb.Text);

            msecs = msecs + 1;
            mseclb.Text = msecs.ToString();
            
            if(msecs >= 60)
            {
                mseclb.Text = "00";
                secs = secs + 1;
                seclb.Text = secs.ToString();
            }
            else if(secs >= 60)
                {
                seclb.Text = "00";
                mins = mins + 1;
                minlb.Text = mins.ToString();
            }
            else if(mins >= 60)
            {
                minlb.Text = "00";
                hrs = hrs + 1;
                hrslb.Text = hrs.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mseclb.Text = "00";
            seclb.Text = "00";
            minlb.Text = "00";
            hrslb.Text = "00";
            timer1.Enabled = false;
        }
    }
}
