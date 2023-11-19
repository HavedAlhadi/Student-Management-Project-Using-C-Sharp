using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homwork
{
    public partial class StudentPag : Form
    {
        public StudentPag()
        {
            InitializeComponent();
        }
        
      OpenFileDialog op = new OpenFileDialog();
        string finame = "";
        int i = -1;
        Bitmap pm;
        private void Myclear()
        {
            textName.Clear();
            textNumber.Clear();
            txt_secti.Clear();
            Male.Checked = false;
            Famle.Checked = false;
             comboBoxstat.Text= "الحالة الدراسية:";
            pictureBox1.Image = Image.FromFile("D:/My Program C#/My All Homwork/Homwork/Resources/studimag.jpg");
            finame = "";
            comboBoxDrowing.Text = "Draw Image";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile("D:/My Program C#/My All Homwork/Homwork/Resources/studimag.jpg");
        }
       
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(dataGridView1.Rows[i].Cells[5].Value.ToString());
        }
      
        private void btn_del_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count>0)
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(i>=0)
            {

                FormEditorSted FEditorSted = new FormEditorSted(
                dataGridView1.Rows[i].Cells[0].Value.ToString(),
                dataGridView1.Rows[i].Cells[1].Value.ToString(),
                dataGridView1.Rows[i].Cells[2].Value.ToString(),
                dataGridView1.Rows[i].Cells[3].Value.ToString(),
                dataGridView1.Rows[i].Cells[4].Value.ToString(),
                dataGridView1.Rows[i].Cells[5].Value.ToString());
                FEditorSted.ShowDialog();
                dataGridView1.Rows[i].Cells[0].Value = FEditorSted.textNumber1.Text;
                dataGridView1.Rows[i].Cells[1].Value = FEditorSted.textName.Text;
                if (FEditorSted.Male1.Checked==true)
                    dataGridView1.Rows[i].Cells[2].Value = FEditorSted.Male1.Text;
                else if (FEditorSted.Famle1.Checked == true)
                    dataGridView1.Rows[i].Cells[2].Value = FEditorSted.Famle1.Text;
                dataGridView1.Rows[i].Cells[3].Value = FEditorSted.comboBoxstat.SelectedItem;
                dataGridView1.Rows[i].Cells[4].Value = FEditorSted.txt_secti.Text;
                dataGridView1.Rows[i].Cells[5].Value = FEditorSted.finame;
            }
            else
            {
                MessageBox.Show("لا يوجد أي طلاب لتعديل");
            }        
        }
      
        
            private void btn_add_Click(object sender, EventArgs e)
        {
            if (textNumber.Text.Trim() == "")
            {
                MessageBox.Show("أدخل رقم الطالب");
                textNumber.Focus();
            }
            else if (textName.Text.Trim() == "")
            {
                MessageBox.Show("أدخل إسم الطالب");
                textName.Focus();
            }
            else if (Male.Checked == false && Famle.Checked == false)
            {
                MessageBox.Show("لم تختار جنس الطالب");
            }
            else if (comboBoxstat.SelectedItem == null)
            {
                MessageBox.Show("إختر الحالة الدراسية");
                comboBoxstat.Focus();
            }
            else if (txt_secti.Text.Trim() == "")
            {
                MessageBox.Show("أدخل إسم القسم");
                txt_secti.Focus();
            }         
            else if (finame =="")
            {
                MessageBox.Show("لم تختر صورة");
                butAddimg_Click(null,null);

            }
            else if (Male.Checked && textName.Text.Trim() != "" && textNumber.Text.Trim() != "" && txt_secti.Text.Trim() != "" && comboBoxstat.SelectedItem != null && finame.Trim() != "")
            {
                dataGridView1.Rows.Add(textNumber.Text, textName.Text, "ذكر", comboBoxstat.SelectedItem, txt_secti.Text, finame);
                Myclear();
                //i++;
            }
            else if (Famle.Checked && textName.Text.Trim() != "" && textNumber.Text.Trim() != "" && txt_secti.Text.Trim() != "" && comboBoxstat.SelectedItem != null && finame.Trim() != "")
            {
                dataGridView1.Rows.Add(textNumber.Text, textName.Text, "أنثى", comboBoxstat.SelectedItem, txt_secti.Text, finame);
                Myclear();
                //i++;
            }                    
        }
        private void textNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 58) && e.KeyChar != 8)
            {
                e.KeyChar = '\n';

            }            
        }

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 47 && e.KeyChar <= 58))
            {
                e.KeyChar = '\n';
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dataGridView1.CurrentRow.Index;
            pictureBox1.Image = Image.FromFile("D:/My Program C#/My All Homwork/Homwork/Resources/studimag.jpg");
            //MessageBox.Show(i.ToString());
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            i = dataGridView1.CurrentRow.Index;
            pictureBox1.Image = Image.FromFile("D:/My Program C#/My All Homwork/Homwork/Resources/studimag.jpg");
        }

        private void butAddimg_Click(object sender, EventArgs e)
        {
            
            op.InitialDirectory = "E";
            if (op.ShowDialog() == DialogResult.OK)
            {
                finame = op.FileName;
                pictureBox1.Image = Image.FromFile(finame);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (finame == ""&& i>1)
                MessageBox.Show("no slected image");
            else if(i<0)
            {
                EditImage ed = new EditImage();
                ed.ofd.FileName = finame;
                ed.pictureBox1.Image = pictureBox1.Image;
                ed.pictureBox2.Image = pictureBox1.Image;
                ed.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                ed.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                ed.ShowDialog();
            }
            else
            {
                EditImage ed = new EditImage();
                ed.pictureBox1.Image = pictureBox1.Image;
                ed.pictureBox2.Image = pictureBox1.Image;
                ed.ofd.FileName = dataGridView1.Rows[i].Cells[5].Value.ToString() ;
                ed.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                ed.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                ed.ShowDialog();
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDrowing.SelectedItem == "Draw Sin")
            {
                pm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                for (int i = 0; i < pictureBox1.Width; i++)
                    pm.SetPixel(i, pictureBox1.Height / 2, Color.Brown);

                for (int i = 0; i < pictureBox1.Height; i++)
                    pm.SetPixel(pictureBox1.Width / 2, i, Color.Brown);
                pictureBox1.Image = pm;
                // pm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                int pw = pictureBox1.Width / 2;
                int ph = pictureBox1.Height / 2;
                for (int x = -180; x < 180; x++)
                {
                    int y = (int)(Math.Sin(x * Math.PI / 180) * 50);

                    pm.SetPixel(pw + x, ph - y, Color.Blue);

                }
                pictureBox1.Image = pm;
            }
            else if (comboBoxDrowing.SelectedItem == "Draw Cos")
            {
                pm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                for (int i = 0; i < pictureBox1.Width; i++)
                    pm.SetPixel(i, pictureBox1.Height / 2, Color.Brown);

                for (int i = 0; i < pictureBox1.Height; i++)
                    pm.SetPixel(pictureBox1.Width / 2, i, Color.Brown);
                pictureBox1.Image = pm;
                int pw = pictureBox1.Width / 2;
                int ph = pictureBox1.Height / 2;
                for (int x = -180; x < 180; x++)
                {
                    int y = (int)(Math.Cos(x * Math.PI / 180) * 30);
                    pm.SetPixel(pw + x, ph - y, Color.Red);
                }
                pictureBox1.Image = pm;
            }
            else if (comboBoxDrowing.SelectedItem == "Clear")
            {
              
                pictureBox1.Image = Image.FromFile("D:/My Program C#/My All Homwork/Homwork/Resources/studimag.jpg");
                comboBoxDrowing.Text = "Draw Image";
            }
        }

        private void but_SaveDraw_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG|*.JPG|PNG|*.PNG|GIF|*.GIF|BMP|*.BMP|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Bitmap bitmap = new Bitmap(pictureBox1.Image))
                    {
                        bitmap.Save(sfd.FileName, ImageFormat.Jpeg);
                    }
                    MessageBox.Show("Image Saved Successfully.");
                }
                catch (Exception xe)
                {
                    MessageBox.Show("Error");
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
