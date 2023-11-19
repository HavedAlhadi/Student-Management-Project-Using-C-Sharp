using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homwork
{
    public partial class time : Form
    {
        int s = 0, h = 0, m = 0, i = 0;
        public time()
        {
            InitializeComponent();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (s < 60)

                label3.Text = (++s).ToString();
            else if (s == 60)
            {
                s = 0;
                label3.Text = (s).ToString();
                if (m < 60)
                    label2.Text = (++m).ToString();


                else if (m == 60)
                {
                    m = 0;
                    label2.Text = (m).ToString();
                    if (h < 12)
                        label1.Text = (++h).ToString();
                    else
                    {
                        h = 0;
                        label1.Text = h.ToString();
                    }
                }

            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                timer1.Start();
                button1.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                button1.Text = "Start";
            }
        }
    }
}
