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

    public partial class EditImage : Form
    {
        Image img;
       public OpenFileDialog ofd = new OpenFileDialog();
        Rectangle Rect = new Rectangle();
        Point a;
        Point b;
        float cont = 0;
        Boolean mouseDown = false;
        public EditImage()
        {
            InitializeComponent();
        }
        public EditImage(string f)
        {
            InitializeComponent();
            ofd.FileName=f;
            //pictureBox1.Image = new Bitmap(ofd.FileName);
            //pictureBox2.Image = new Bitmap(ofd.FileName);
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void EditImage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            ofd.Filter = "images|*.png;*.jpg;*.jpeg;*.gif";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                pictureBox2.Image = new Bitmap(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                txt_imgpath.Text = ofd.FileName;
                img = Image.FromFile(ofd.FileName);
                labelImagePath.Text = pictureBox1.Image.Size.ToString(); // To displaye the image size//
            }
            else
            {
                pictureBox1.Image = pictureBox2.Image;
            }

        }

        private void panelRightcontrol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelporderimage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelShowimage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelWidth_Click(object sender, EventArgs e)
        {

        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void butCenter_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            but_Close.Size = new Size(39, 35);
        }

        private void but_Close_MouseMove(object sender, MouseEventArgs e)
        {
            but_Close.Size = new Size(45, 40);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG|*.JPG|PNG|*.PNG|GIF|*.GIF|BMP|*.BMP|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Bitmap bitmap = new Bitmap(pictureBox2.Image))
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
        new Image Resize(Image image, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(image, 0, 0, width, height);
            graphic.Dispose();
            return bmp;
        }

        private void but_resize_Click(object sender, EventArgs e)
        {
            if (text_Width.Text.Trim() != "" && text_Height.Text.Trim() != "")
                {
                int width = Convert.ToInt32(text_Width.Text), height = Convert.ToInt32(text_Height.Text);
                img = Resize(img, width, height);
                pictureBox2.Image = img;
                text_Width.Text = "";
                text_Height.Text = "";
            }
            else
            {
                MessageBox.Show("Enter Width and Hieght");
            }

        }
        void reload()
        {
            img = Image.FromFile(ofd.FileName);
            pictureBox1.Image = img;
        }

        private void but_reload_Click(object sender, EventArgs e)
        {

            text_Width.Text = "";
            text_Height.Text = "";
            trk_hue.Value = 0;
            trk_Contrast.Value = 0;
            trk_bright.Value = 0;
            reload();

        }

        private void but_rotate_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
            pictureBox1.Refresh();

        }

        private void butZoom_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }
        void f1()
        {
            img = pictureBox1.Image;
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][] {
             new float[] {0,0,1,0,0},
             new float[] {0,1,0,0,0},
             new float[] {0,0,0,0,0},
             new float[] {0,0,0,1,0},
             new float[]{0,0,0,0,1} });
            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpinverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox1.Image = bmpinverted;
        }

        private void but_f1_Click(object sender, EventArgs e)
        {
            reload();
            f1();

        }
        void f2()
        {
            img = pictureBox1.Image;
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][] {
              new float[]{.393f, .349f, .272f, 0, 0},
              new float[]{.769f, .686f, .534f, 0, 0},
              new float[]{.189f, .168f, .131f, 0, 0},
              new float[]{0, 0, 0, 1, 0},
              new float[]{0, 0, 0, 0, 1} });
            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpinverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox1.Image = bmpinverted;
        }

        private void but_f2_Click(object sender, EventArgs e)
        {
            reload();
                f2();
        }
        void f3()
        {
            img = pictureBox1.Image;
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][] {
              new float[]{.3f, .3f, .3f, 0, 0},    //Grayscale Filter//
              new float[]{.59f, .59f, .59f, 0, 0},
              new float[]{.11f, .11f, .11f, 0, 0},
              new float[]{0, 0, 0, 1, 0},
              new float[]{0, 0, 0, 0, 1} });
            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpinverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox1.Image = bmpinverted;
        }

        private void but_f3_Click(object sender, EventArgs e)
        {
            reload();
            f3();
        }
        void f4()
        {
            img = pictureBox1.Image;
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][] {
             new float[] {1,1,0,0,0,0},
             new float[] {0,0,1,0,0},
             new float[] {0,0,0,0,0},
             new float[] {0,0,0,1,0},
             new float[]{0,0,0,0,1} });
            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpinverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox1.Image = bmpinverted;
        }

        private void but_f4_Click(object sender, EventArgs e)
        {
          //  reload();
            f4();
        }
        void f5()
        {
            img = pictureBox1.Image;
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][] {
             new float[] {1,1,1,0,0},
             new float[] {0,0,1,1,0},
             new float[] {0,0,0,0,0},
             new float[] {0,0,0,1,0},
             new float[]{0,0,0,0,1} });
            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpinverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox1.Image = bmpinverted;
        }

        private void but_f5_Click(object sender, EventArgs e)
        {
            //reload();
            f5();
        }
        void hue()
        {
            img = pictureBox1.Image;
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][] {
             new float[] {1,0,(trk_hue.Value),0,0,0,0},
             new float[] {0,1,0,0,0},
             new float[] {0,0,0,0,0},
             new float[] {0,0,0,1,0},
             new float[]{0,0,0,0,1} });
            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpinverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox1.Image = bmpinverted;
            pictureBox2.Image = pictureBox1.Image;

        }
        private void trk_hue_ValueChanged(object sender, EventArgs e)
        {
            reload();
            hue();

        }
        void contrast()
        {
            cont = 0.2f * trk_Contrast.Value;
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][] {
              new float[]{cont ,0f,0f,0f,0f },
              new float[]{0f,cont,0f,0f,0f },
              new float[]{0f,0f,cont,0f,0f },
              new float[]{0f,0f,0f,1f,0f },
              new float[]{0.001f,0.001f,0.001f,0f,1f} });
            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpinverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox1.Image = bmpinverted;
        }
        private void trk_Contrast_ValueChanged(object sender, EventArgs e)
        {
            //reload();
            contrast();
        }
        void bright()
        {
            img = pictureBox1.Image;
            float fvalue = trk_bright.Value / 50f;
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][] {
            new float[] {1,0,0,0,0},
             new float[] {0,1,0,0,0},
             new float[] {0,0,1,0,0 },
             new float[] {0,0,0,0,0},
             new float[]{fvalue,fvalue,fvalue,1,1} });
            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpinverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox1.Image = bmpinverted;
        }

        private void trk_bright_ValueChanged(object sender, EventArgs e)
        {
            
            bright();
        }

        private void trk_Contrast_Scroll(object sender, EventArgs e)
        {
            reload();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            a = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                b = e.Location;
                Refresh();
            }
        }
       

        private Rectangle GetRect()
        {
           // Rect = new Rectangle();
            Rect.X = Math.Min(a.X, b.X);
            Rect.Y = Math.Min(a.Y, b.Y);
            Rect.Width = Math.Abs(a.X - b.X);
            Rect.Height = Math.Abs(a.Y - b.Y);
            return Rect;

        }
         private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                b = e.Location;
                mouseDown = false;


                if (Rect != null&& Rect.Width!=0&& Rect.Height!=0)
                {
                    Bitmap bitm = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
                    Bitmap crop = new Bitmap(Rect.Width, Rect.Height);
                    Graphics g = Graphics.FromImage(crop);
                    g.DrawImage(bitm, 0, 0, Rect, GraphicsUnit.Pixel);
                    pictureBox2.Image = crop;

                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (Rect != null)
            {
                e.Graphics.DrawRectangle(Pens.Aqua, GetRect());
            }
        }
    }

}
