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
    public partial class pag3 : Form
    {
        public pag3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.Left -= this.Width;
            this.Width = button1.Width + 30;
            button1.Left = 10;
            button2.Left = 10;
            button3.Left = 10;
            button4.Left = 10;
        }
        void showpanel()
        {
            this.Width = panel1.Width + button1.Width + 40;
            button1.Left = this.Width - button1.Width - 20;
            button2.Left = this.Width - button1.Width - 20;
            button3.Left = this.Width - button1.Width - 20;
            button4.Left = this.Width - button1.Width - 20;
            panel1.Left = this.Width - button1.Width - panel1.Width - 20;
        }
        private void myclean()
        {
            foreach (Control c in panel1.Controls)
                if (c is TextBox)
                    c.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            myclean();
            showpanel();
            label1.Text = "+";
            button5.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myclean();
            showpanel();
            label1.Text = "-";
            button5.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myclean();
            showpanel();
            label1.Text = "*";
            button5.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myclean();
            showpanel();
            label1.Text = "/";
            button5.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim()!= "" && textBox2.Text.Trim() != "")
                {
                    switch (label1.Text)
                    {
                        case "+":
                            {
                                textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
                                break;
                            }
                        case "-":
                            textBox3.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
                            break;
                        case "*":
                            textBox3.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
                            break;
                        case "/":
                            {
                                if (Convert.ToInt32(textBox2.Text) != 0)
                                    textBox3.Text = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)).ToString();
                                else
                                    MessageBox.Show("Divided by zero");
                            }
                            break;
                    }
                }
                else
                    MessageBox.Show("No Valuese entered", "Note", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
            
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void butback2_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           if ((e.KeyChar<47||e.KeyChar>58)&&e.KeyChar!=8)
            {
                e.KeyChar = '\n';
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 58) && e.KeyChar != 8)
            {
                e.KeyChar = '\n';
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
