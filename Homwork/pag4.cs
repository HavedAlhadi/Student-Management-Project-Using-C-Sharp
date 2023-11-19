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
    public partial class pag4 : Form
    {
        public pag4()
        {
            InitializeComponent();
        }
        float a = 0, b = 0, c = 0, d = 0;
        float i = 0, j = 0, k = 0, h = 0;

        private void groupBoxco_Enter(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxs_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            if (!radioButtonYes.Checked && !radioButtonNos.Checked && !radioButtonYesth.Checked && !radioButtonNoth.Checked && !radioButtonYesco.Checked && !radioButtonNoco.Checked && !radioButtonYesm.Checked && !radioButtonNom.Checked)
            {
                MessageBox.Show("لم تختر شيء", "عزيزي");
            }
            else if (radioButtonNos.Checked && radioButtonNoth.Checked && radioButtonNoco.Checked && radioButtonNom.Checked)
            {
                a++; b++; c++; d++;
                MessageBox.Show("أنت في صحة جيدة", "لله الحمد");
            }
            else
            {
                if (radioButtonYes.Checked)
                {
                    i++;
                   
                }
                else if(radioButtonNos.Checked)
                    a++;

                if (radioButtonYesth.Checked)
                {
                    j++;
                }
                else if (radioButtonNoth.Checked)
                    b++;
                if (radioButtonYesco.Checked)
                {
                    k++;
                }
                else if (radioButtonNoco.Checked)
                    c++;
                if (radioButtonYesm.Checked)
                {
                    h++;
                }
                else if (radioButtonNom.Checked)
                    d++;

                MessageBox.Show(" ثم الإضافة", "شكرا لك");
            }
            radioButtonYes.Checked = false;
            radioButtonNos.Checked = false;
            radioButtonYesth.Checked = false; 
            radioButtonNoth.Checked = false; 
            radioButtonYesco.Checked = false;
            radioButtonNoco.Checked = false; 
            radioButtonYesm.Checked = false; 
            radioButtonNom.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            Mytag t = new Mytag(i,j,k,h,a,b,c,d);
            t.ShowDialog();
        }
    }
}
