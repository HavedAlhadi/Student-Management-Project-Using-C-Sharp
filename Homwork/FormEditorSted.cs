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
    public partial class FormEditorSted : Form     {
        //string Number, name, gander, stast, secti, finame;
        public string finame;
        StudentPag d = new StudentPag();
        public FormEditorSted()
        {
            InitializeComponent();
        }
        OpenFileDialog op = new OpenFileDialog();
        

        private void butAddimg_Click(object sender, EventArgs e)
        {
            op.InitialDirectory = "E";
            if (op.ShowDialog() == DialogResult.OK)
            {
                finame = op.FileName;
                pictureBoxeditor.Image = Image.FromFile(finame);
            }
        }
        public FormEditorSted(string Number1, string Name1, string gander1, string stast1, string secti1, string fname1)
        {
            InitializeComponent();

            textNumber1.Text = Number1;
            textName.Text = Name1;
            if (gander1 == "ذكر")
            {
                Male1.Checked = true;
           
            }
            else
                Famle1.Checked = true;
            comboBoxstat.Text = stast1;
            txt_secti.Text = secti1;
            pictureBoxeditor.Image = Image.FromFile(fname1);
            finame = fname1;
            //btn_edit.Click += new EventHandler(btn_edit_Click); 
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }     
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormEditorSted_Load(object sender, EventArgs e)
        {

        }

        private void paneleditorsted_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void textNumber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 && e.KeyChar > 58)&& e.KeyChar!=8)
            {
                e.KeyChar = '\n';

            }
        }
    }
}
