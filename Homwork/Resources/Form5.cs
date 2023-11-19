using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exeBackExam
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        OpenFileDialog op=new OpenFileDialog();
        string finame="";
        int i =0;
        private void txt_img_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txt_name.Text, txt_cas.Text, txt_secti.Text, finame);
            //dataGridView1.Rows[i]txt_cas.Text;.Cells[0].Value = txt_name.Text;
            //dataGridView1.Rows[i]txt_secti.Text;.Cells[1].Value = txt_cas.Text;
            //dataGridView1.Rows[i]finame;.Cells[2].Value = txt_secti.Text;
            //dataGridView1.Rows[i].Cells[3].Value = finame;
            //i++;

        }
        private void txt_img_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            op.InitialDirectory = "E";
            if (op.ShowDialog() == DialogResult.OK)
                finame = op.FileName;

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
           // dataGridView1.Rows[i].Cells[0].Value=;
              dataGridView1.Rows[i].Cells[0].Value = txt_name.Text;
            dataGridView1.Rows[i].Cells[1].Value = txt_cas.Text;
            dataGridView1.Rows[i].Cells[2].Value = txt_secti.Text;
            dataGridView1.Rows[i].Cells[3].Value = finame;
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(dataGridView1.Rows[i].Cells[3].Value.ToString());

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            i = dataGridView1.CurrentRow.Index;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }
    }
}
