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
    public partial class notbad : Form
    {
        public notbad()
        {
            InitializeComponent();
        }
        string[] str = new string[100];
        int count = 0;

        // دالع توجد طول النص وطول النص المحدد
        void LengthText()
        {
            txt_Length.Text = txt_Main.Text.Length.ToString();
            txt_SelectLength.Text = txt_Main.SelectionLength.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LengthText();
            txt_Main.SelectionStart = 0;
            str[count] = txt_Main.Text;
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            txt_Main.Copy();         // نسخ الى حافضة الجهاز
            txt_clipboard.Text = Clipboard.GetText();
        }

        private void btn_cut_Click(object sender, EventArgs e)
        {
            txt_Main.Cut();          // قص الى حافضة الجهاز
            txt_clipboard.Text = Clipboard.GetText();
        }

        private void btn_paste_Click(object sender, EventArgs e)
        {
            txt_Main.Paste();  // لصق من الحافضة الى صندوق النص الرئيسية

        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
                txt_Main.Text = str[count];
            }
        }

        private void btn_redo_Click(object sender, EventArgs e)
        {
            if (str[++count] != null && count <= 100)
            {
                txt_Main.Clear();
                txt_Main.Text = str[count];
            }
        }

        private void txt_Main_MouseUp(object sender, MouseEventArgs e)
        {
            LengthText();
        }

        private void txt_Main_KeyUp(object sender, KeyEventArgs e)
        {
            LengthText();
            if (e.Control == true && e.KeyValue == 67)  //ctrl+c
            {
                btn_copy_Click(sender, e);
            }
            else if (e.Control == true && e.KeyValue == 88) // ctrl+x
                btn_cut_Click(sender, e);
            else if (e.Control == true && e.KeyValue == 90) // ctrl+z
                btn_undo_Click(sender, e);
            else if (e.Control == true && e.KeyValue == 89)  // ctrl+y
                btn_redo_Click(sender, e);
            else
            {
                if (count != 100)
                {
                    count++;
                    str[count] = txt_Main.Text;
                }
            }
        }

        private void txt_Main_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SelectLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Length_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_clipboard_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Main_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
