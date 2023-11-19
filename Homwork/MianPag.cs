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
    public partial class MianPag : Form
    {
        public MianPag()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Homwork1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homwork2 Hom = new Homwork2();
            Hom.Show();
        }

        private void Homwork2_Click(object sender, EventArgs e)
        {

            this.Hide();
            pag3 Hom = new pag3();
            Hom.Show();
        }
        private void Homwork3_Click_1(object sender, EventArgs e)
        {
            pag4 H = new pag4();
            H.ShowDialog();
        }

        private void Homwork4_Click_1(object sender, EventArgs e)
        {
            StudentPag Hom4 = new StudentPag();
            Hom4.ShowDialog();
        }
    }
}
