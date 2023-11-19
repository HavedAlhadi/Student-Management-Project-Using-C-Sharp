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
    public partial class Myprogect : Form
    {
        int s;
        public Myprogect()
        {
            InitializeComponent();
        }
        private bool isprimary(int x)
        {
            for (int j = 2; j < x; j++)
                if (x % j == 0)
                    return false;
            return true;
        }
        bool Found(int a)
        {
            for (int i = 0; i < listadd.Items.Count; i++)
            {
                if (a==(Convert.ToInt32(listadd.Items[i])))
                {
                    return false;
                }
            }
            return true;
        }
        bool isodd(int x)
        {
            return (x % 2 == 1);
        }
        bool iseven(int x)
        {
            return (x % 2 == 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Myprogect_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Found(Convert.ToInt16(EnsertText.Text)))
            {

                listadd.Items.Add(EnsertText.Text);
            }
            EnsertText.Clear();
            EnsertText.Focus();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Myprogect_Load_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listadd.Items.Count; i++)
            {
                if (isprimary(Convert.ToInt32(listadd.Items[i])))
                {
                    
                    listshow.Items.Add(listadd.Items[i]);
                    listadd.Items.Remove(listadd.Items[i]);
                    i--;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnsertText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 58) && e.KeyChar != 8)
            {
                e.KeyChar = '\n';

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listadd.Items.Count; i++)
            {
                if (isodd(Convert.ToInt32(listadd.Items[i])))
                {
                    listshow.Items.Add(listadd.Items[i]);
                    listadd.Items.Remove(listadd.Items[i]);
                    i--;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listadd.Items.Count; i++)
            {
                if (iseven(Convert.ToInt32(listadd.Items[i])))
                {
                    listshow.Items.Add(listadd.Items[i]);
                    listadd.Items.Remove(listadd.Items[i]);
                    i--;
                }
            }
        }

        private void listadd_SelectedIndexChanged(object sender, EventArgs e)
        {
            s = listadd.SelectedIndex;            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listadd.Items.Remove(listadd.Items[s]);
            listshow.Items.Remove(listadd.Items[s]);
        }
    }
}
