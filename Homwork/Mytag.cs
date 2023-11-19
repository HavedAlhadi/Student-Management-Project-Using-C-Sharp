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
    public partial class Mytag : Form
    {
        public Mytag()
        {
            InitializeComponent();
        }
        public Mytag(float i, float j, float k, float h, float a, float b, float c, float d)
        {
            InitializeComponent();
            textBoxNs.Text= Convert.ToString(i);
            textBoxNth.Text = Convert.ToString(j);
            textBoxNco.Text = Convert.ToString(k);
            textBoxNm.Text = Convert.ToString(h);
            textBoxFs.Text= Convert.ToString((i/(a+i)*100)) + " %";
            textBoxFth.Text = Convert.ToString((j/(b+j)*100)) + " %";
            textBoxFco.Text = Convert.ToString((k/(c+k)*100)) + " %";
            textBoxFm.Text = Convert.ToString((h/(d+h)*100)) + " %";
            //////////////////////////////////////
            textBoxNNs.Text = Convert.ToString(a);
            textBoxNNth.Text = Convert.ToString(b);
            textBoxNNco.Text = Convert.ToString(c);
            textBoxNNm.Text = Convert.ToString(d);
            textBoxFNs.Text = Convert.ToString(((a / (a + i)) * 100)) + " %";
            textBoxFNth.Text = Convert.ToString(((b / (b + j)) * 100)) + " %";
            textBoxFNco.Text = Convert.ToString(((c / (c + k)) * 100)) + " %";
            textBoxFNm.Text = Convert.ToString(((d / (d + h)) * 100)) + " %";
        }

        private void labels_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttoncloseT_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
