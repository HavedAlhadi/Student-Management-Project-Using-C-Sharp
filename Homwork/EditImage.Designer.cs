namespace Homwork
{
    partial class EditImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelToolControl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.but_Close = new System.Windows.Forms.Button();
            this.panelRightcontrol = new System.Windows.Forms.Panel();
            this.panelMyimage = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butCenter = new System.Windows.Forms.Button();
            this.butZoom = new System.Windows.Forms.Button();
            this.butAutoSize = new System.Windows.Forms.Button();
            this.but_Stretch = new System.Windows.Forms.Button();
            this.butNormal = new System.Windows.Forms.Button();
            this.paneldownControl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelContrestbar = new System.Windows.Forms.Label();
            this.labelHuebar = new System.Windows.Forms.Label();
            this.trk_bright = new System.Windows.Forms.TrackBar();
            this.trk_Contrast = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelImagePath = new System.Windows.Forms.Label();
            this.trk_hue = new System.Windows.Forms.TrackBar();
            this.text_Height = new System.Windows.Forms.TextBox();
            this.text_Width = new System.Windows.Forms.TextBox();
            this.txt_imgpath = new System.Windows.Forms.TextBox();
            this.but_resize = new System.Windows.Forms.Button();
            this.but_reload = new System.Windows.Forms.Button();
            this.but_rotate = new System.Windows.Forms.Button();
            this.but_f1 = new System.Windows.Forms.Button();
            this.but_f2 = new System.Windows.Forms.Button();
            this.but_f3 = new System.Windows.Forms.Button();
            this.but_f4 = new System.Windows.Forms.Button();
            this.but_f5 = new System.Windows.Forms.Button();
            this.butSelect_Image = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.panelShowimage = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelporderimage = new System.Windows.Forms.Panel();
            this.panelToolControl.SuspendLayout();
            this.panelRightcontrol.SuspendLayout();
            this.panelMyimage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.paneldownControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_bright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_hue)).BeginInit();
            this.panelShowimage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelporderimage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolControl
            // 
            this.panelToolControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.panelToolControl.Controls.Add(this.label4);
            this.panelToolControl.Controls.Add(this.but_Close);
            this.panelToolControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolControl.Location = new System.Drawing.Point(0, 0);
            this.panelToolControl.Name = "panelToolControl";
            this.panelToolControl.Size = new System.Drawing.Size(978, 41);
            this.panelToolControl.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.YellowGreen;
            this.label4.Location = new System.Drawing.Point(394, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Editor Image";
            // 
            // but_Close
            // 
            this.but_Close.BackColor = System.Drawing.Color.Transparent;
            this.but_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.but_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_Close.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Close.ForeColor = System.Drawing.Color.Red;
            this.but_Close.Location = new System.Drawing.Point(934, 3);
            this.but_Close.Name = "but_Close";
            this.but_Close.Size = new System.Drawing.Size(39, 35);
            this.but_Close.TabIndex = 1;
            this.but_Close.Text = "X";
            this.but_Close.UseVisualStyleBackColor = false;
            this.but_Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelRightcontrol
            // 
            this.panelRightcontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelRightcontrol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRightcontrol.Controls.Add(this.panelMyimage);
            this.panelRightcontrol.Controls.Add(this.label3);
            this.panelRightcontrol.Controls.Add(this.butCenter);
            this.panelRightcontrol.Controls.Add(this.butZoom);
            this.panelRightcontrol.Controls.Add(this.butAutoSize);
            this.panelRightcontrol.Controls.Add(this.but_Stretch);
            this.panelRightcontrol.Controls.Add(this.butNormal);
            this.panelRightcontrol.Location = new System.Drawing.Point(745, 41);
            this.panelRightcontrol.Name = "panelRightcontrol";
            this.panelRightcontrol.Size = new System.Drawing.Size(233, 433);
            this.panelRightcontrol.TabIndex = 1;
            this.panelRightcontrol.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRightcontrol_Paint);
            // 
            // panelMyimage
            // 
            this.panelMyimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMyimage.Controls.Add(this.pictureBox2);
            this.panelMyimage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMyimage.Location = new System.Drawing.Point(0, 0);
            this.panelMyimage.Name = "panelMyimage";
            this.panelMyimage.Size = new System.Drawing.Size(229, 177);
            this.panelMyimage.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 173);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.YellowGreen;
            this.label3.Location = new System.Drawing.Point(67, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Final Image";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // butCenter
            // 
            this.butCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.butCenter.Location = new System.Drawing.Point(4, 336);
            this.butCenter.Name = "butCenter";
            this.butCenter.Size = new System.Drawing.Size(220, 40);
            this.butCenter.TabIndex = 3;
            this.butCenter.Text = "Center";
            this.butCenter.UseVisualStyleBackColor = true;
            this.butCenter.Click += new System.EventHandler(this.butCenter_Click);
            // 
            // butZoom
            // 
            this.butZoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butZoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.butZoom.Location = new System.Drawing.Point(4, 382);
            this.butZoom.Name = "butZoom";
            this.butZoom.Size = new System.Drawing.Size(220, 40);
            this.butZoom.TabIndex = 4;
            this.butZoom.Text = "Zoom";
            this.butZoom.UseVisualStyleBackColor = true;
            this.butZoom.Click += new System.EventHandler(this.butZoom_Click);
            // 
            // butAutoSize
            // 
            this.butAutoSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butAutoSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAutoSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.butAutoSize.Location = new System.Drawing.Point(4, 290);
            this.butAutoSize.Name = "butAutoSize";
            this.butAutoSize.Size = new System.Drawing.Size(220, 40);
            this.butAutoSize.TabIndex = 2;
            this.butAutoSize.Text = "Auto Size";
            this.butAutoSize.UseVisualStyleBackColor = true;
            this.butAutoSize.Click += new System.EventHandler(this.button4_Click);
            // 
            // but_Stretch
            // 
            this.but_Stretch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_Stretch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Stretch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.but_Stretch.Location = new System.Drawing.Point(4, 244);
            this.but_Stretch.Name = "but_Stretch";
            this.but_Stretch.Size = new System.Drawing.Size(220, 40);
            this.but_Stretch.TabIndex = 1;
            this.but_Stretch.Text = "Stretch";
            this.but_Stretch.UseVisualStyleBackColor = true;
            this.but_Stretch.Click += new System.EventHandler(this.button3_Click);
            // 
            // butNormal
            // 
            this.butNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.butNormal.Location = new System.Drawing.Point(4, 197);
            this.butNormal.Name = "butNormal";
            this.butNormal.Size = new System.Drawing.Size(220, 40);
            this.butNormal.TabIndex = 0;
            this.butNormal.Text = "Normal";
            this.butNormal.UseVisualStyleBackColor = true;
            this.butNormal.Click += new System.EventHandler(this.button2_Click);
            // 
            // paneldownControl
            // 
            this.paneldownControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paneldownControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneldownControl.Controls.Add(this.label2);
            this.paneldownControl.Controls.Add(this.labelContrestbar);
            this.paneldownControl.Controls.Add(this.labelHuebar);
            this.paneldownControl.Controls.Add(this.trk_bright);
            this.paneldownControl.Controls.Add(this.trk_Contrast);
            this.paneldownControl.Controls.Add(this.label1);
            this.paneldownControl.Controls.Add(this.labelWidth);
            this.paneldownControl.Controls.Add(this.labelImagePath);
            this.paneldownControl.Controls.Add(this.trk_hue);
            this.paneldownControl.Controls.Add(this.text_Height);
            this.paneldownControl.Controls.Add(this.text_Width);
            this.paneldownControl.Controls.Add(this.txt_imgpath);
            this.paneldownControl.Controls.Add(this.but_resize);
            this.paneldownControl.Controls.Add(this.but_reload);
            this.paneldownControl.Controls.Add(this.but_rotate);
            this.paneldownControl.Controls.Add(this.but_f1);
            this.paneldownControl.Controls.Add(this.but_f2);
            this.paneldownControl.Controls.Add(this.but_f3);
            this.paneldownControl.Controls.Add(this.but_f4);
            this.paneldownControl.Controls.Add(this.but_f5);
            this.paneldownControl.Controls.Add(this.butSelect_Image);
            this.paneldownControl.Controls.Add(this.butSave);
            this.paneldownControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneldownControl.Location = new System.Drawing.Point(0, 471);
            this.paneldownControl.Name = "paneldownControl";
            this.paneldownControl.Size = new System.Drawing.Size(978, 169);
            this.paneldownControl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(703, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Brightness";
            // 
            // labelContrestbar
            // 
            this.labelContrestbar.AutoSize = true;
            this.labelContrestbar.BackColor = System.Drawing.Color.Transparent;
            this.labelContrestbar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelContrestbar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrestbar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelContrestbar.Location = new System.Drawing.Point(463, 66);
            this.labelContrestbar.Name = "labelContrestbar";
            this.labelContrestbar.Size = new System.Drawing.Size(69, 20);
            this.labelContrestbar.TabIndex = 24;
            this.labelContrestbar.Text = "Contrast";
            // 
            // labelHuebar
            // 
            this.labelHuebar.AutoSize = true;
            this.labelHuebar.BackColor = System.Drawing.Color.Transparent;
            this.labelHuebar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelHuebar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHuebar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelHuebar.Location = new System.Drawing.Point(249, 66);
            this.labelHuebar.Name = "labelHuebar";
            this.labelHuebar.Size = new System.Drawing.Size(37, 20);
            this.labelHuebar.TabIndex = 23;
            this.labelHuebar.Text = "Hue";
            // 
            // trk_bright
            // 
            this.trk_bright.Location = new System.Drawing.Point(782, 58);
            this.trk_bright.Name = "trk_bright";
            this.trk_bright.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trk_bright.Size = new System.Drawing.Size(176, 56);
            this.trk_bright.TabIndex = 22;
            this.trk_bright.ValueChanged += new System.EventHandler(this.trk_bright_ValueChanged);
            // 
            // trk_Contrast
            // 
            this.trk_Contrast.Location = new System.Drawing.Point(530, 58);
            this.trk_Contrast.Name = "trk_Contrast";
            this.trk_Contrast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trk_Contrast.Size = new System.Drawing.Size(176, 56);
            this.trk_Contrast.TabIndex = 21;
            this.trk_Contrast.Scroll += new System.EventHandler(this.trk_Contrast_Scroll);
            this.trk_Contrast.ValueChanged += new System.EventHandler(this.trk_Contrast_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Height";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.BackColor = System.Drawing.Color.Transparent;
            this.labelWidth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelWidth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.ForeColor = System.Drawing.Color.White;
            this.labelWidth.Location = new System.Drawing.Point(32, 51);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(52, 20);
            this.labelWidth.TabIndex = 19;
            this.labelWidth.Text = "Width";
            this.labelWidth.Click += new System.EventHandler(this.labelWidth_Click);
            // 
            // labelImagePath
            // 
            this.labelImagePath.AutoSize = true;
            this.labelImagePath.BackColor = System.Drawing.Color.Transparent;
            this.labelImagePath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelImagePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImagePath.ForeColor = System.Drawing.Color.YellowGreen;
            this.labelImagePath.Location = new System.Drawing.Point(133, -1);
            this.labelImagePath.Name = "labelImagePath";
            this.labelImagePath.Size = new System.Drawing.Size(89, 20);
            this.labelImagePath.TabIndex = 0;
            this.labelImagePath.Text = "Image Path";
            // 
            // trk_hue
            // 
            this.trk_hue.Location = new System.Drawing.Point(283, 58);
            this.trk_hue.Name = "trk_hue";
            this.trk_hue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trk_hue.Size = new System.Drawing.Size(176, 56);
            this.trk_hue.TabIndex = 16;
            this.trk_hue.ValueChanged += new System.EventHandler(this.trk_hue_ValueChanged);
            // 
            // text_Height
            // 
            this.text_Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_Height.Location = new System.Drawing.Point(120, 73);
            this.text_Height.Multiline = true;
            this.text_Height.Name = "text_Height";
            this.text_Height.Size = new System.Drawing.Size(92, 30);
            this.text_Height.TabIndex = 15;
            this.text_Height.TextChanged += new System.EventHandler(this.textBoxHeight_TextChanged);
            // 
            // text_Width
            // 
            this.text_Width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_Width.Location = new System.Drawing.Point(10, 73);
            this.text_Width.Multiline = true;
            this.text_Width.Name = "text_Width";
            this.text_Width.Size = new System.Drawing.Size(92, 30);
            this.text_Width.TabIndex = 14;
            this.text_Width.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
            // 
            // txt_imgpath
            // 
            this.txt_imgpath.AcceptsReturn = true;
            this.txt_imgpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_imgpath.Location = new System.Drawing.Point(10, 18);
            this.txt_imgpath.Multiline = true;
            this.txt_imgpath.Name = "txt_imgpath";
            this.txt_imgpath.Size = new System.Drawing.Size(379, 30);
            this.txt_imgpath.TabIndex = 0;
            // 
            // but_resize
            // 
            this.but_resize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_resize.ForeColor = System.Drawing.Color.White;
            this.but_resize.Location = new System.Drawing.Point(29, 117);
            this.but_resize.Name = "but_resize";
            this.but_resize.Size = new System.Drawing.Size(64, 36);
            this.but_resize.TabIndex = 13;
            this.but_resize.Text = "Set";
            this.but_resize.UseVisualStyleBackColor = true;
            this.but_resize.Click += new System.EventHandler(this.but_resize_Click);
            // 
            // but_reload
            // 
            this.but_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_reload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.but_reload.Location = new System.Drawing.Point(121, 117);
            this.but_reload.Name = "but_reload";
            this.but_reload.Size = new System.Drawing.Size(115, 36);
            this.but_reload.TabIndex = 12;
            this.but_reload.Text = "Raset";
            this.but_reload.UseVisualStyleBackColor = true;
            this.but_reload.Click += new System.EventHandler(this.but_reload_Click);
            // 
            // but_rotate
            // 
            this.but_rotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_rotate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.but_rotate.Location = new System.Drawing.Point(243, 117);
            this.but_rotate.Name = "but_rotate";
            this.but_rotate.Size = new System.Drawing.Size(115, 36);
            this.but_rotate.TabIndex = 11;
            this.but_rotate.Text = "Rotate";
            this.but_rotate.UseVisualStyleBackColor = true;
            this.but_rotate.Click += new System.EventHandler(this.but_rotate_Click);
            // 
            // but_f1
            // 
            this.but_f1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_f1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_f1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.but_f1.Location = new System.Drawing.Point(364, 117);
            this.but_f1.Name = "but_f1";
            this.but_f1.Size = new System.Drawing.Size(115, 36);
            this.but_f1.TabIndex = 10;
            this.but_f1.Text = "Filter 1";
            this.but_f1.UseVisualStyleBackColor = true;
            this.but_f1.Click += new System.EventHandler(this.but_f1_Click);
            // 
            // but_f2
            // 
            this.but_f2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_f2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_f2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.but_f2.Location = new System.Drawing.Point(485, 117);
            this.but_f2.Name = "but_f2";
            this.but_f2.Size = new System.Drawing.Size(115, 36);
            this.but_f2.TabIndex = 9;
            this.but_f2.Text = "Filter 2";
            this.but_f2.UseVisualStyleBackColor = true;
            this.but_f2.Click += new System.EventHandler(this.but_f2_Click);
            // 
            // but_f3
            // 
            this.but_f3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_f3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_f3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.but_f3.Location = new System.Drawing.Point(606, 117);
            this.but_f3.Name = "but_f3";
            this.but_f3.Size = new System.Drawing.Size(115, 36);
            this.but_f3.TabIndex = 8;
            this.but_f3.Text = "Filter3";
            this.but_f3.UseVisualStyleBackColor = true;
            this.but_f3.Click += new System.EventHandler(this.but_f3_Click);
            // 
            // but_f4
            // 
            this.but_f4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_f4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_f4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.but_f4.Location = new System.Drawing.Point(727, 117);
            this.but_f4.Name = "but_f4";
            this.but_f4.Size = new System.Drawing.Size(115, 36);
            this.but_f4.TabIndex = 7;
            this.but_f4.Text = "Filter4";
            this.but_f4.UseVisualStyleBackColor = true;
            this.but_f4.Click += new System.EventHandler(this.but_f4_Click);
            // 
            // but_f5
            // 
            this.but_f5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_f5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_f5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.but_f5.Location = new System.Drawing.Point(848, 117);
            this.but_f5.Name = "but_f5";
            this.but_f5.Size = new System.Drawing.Size(115, 36);
            this.but_f5.TabIndex = 5;
            this.but_f5.Text = "Filter5";
            this.but_f5.UseVisualStyleBackColor = true;
            this.but_f5.Click += new System.EventHandler(this.but_f5_Click);
            // 
            // butSelect_Image
            // 
            this.butSelect_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butSelect_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSelect_Image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butSelect_Image.Location = new System.Drawing.Point(395, 19);
            this.butSelect_Image.Name = "butSelect_Image";
            this.butSelect_Image.Size = new System.Drawing.Size(242, 29);
            this.butSelect_Image.TabIndex = 6;
            this.butSelect_Image.Text = "Select Image";
            this.butSelect_Image.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butSelect_Image.UseVisualStyleBackColor = true;
            this.butSelect_Image.Click += new System.EventHandler(this.button8_Click);
            // 
            // butSave
            // 
            this.butSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.butSave.Location = new System.Drawing.Point(643, 19);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(231, 29);
            this.butSave.TabIndex = 5;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // panelShowimage
            // 
            this.panelShowimage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelShowimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShowimage.Controls.Add(this.pictureBox1);
            this.panelShowimage.Location = new System.Drawing.Point(9, 5);
            this.panelShowimage.Name = "panelShowimage";
            this.panelShowimage.Size = new System.Drawing.Size(725, 413);
            this.panelShowimage.TabIndex = 0;
            this.panelShowimage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelShowimage_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 411);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panelporderimage
            // 
            this.panelporderimage.BackColor = System.Drawing.Color.YellowGreen;
            this.panelporderimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelporderimage.Controls.Add(this.panelShowimage);
            this.panelporderimage.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelporderimage.Location = new System.Drawing.Point(0, 41);
            this.panelporderimage.Name = "panelporderimage";
            this.panelporderimage.Size = new System.Drawing.Size(745, 430);
            this.panelporderimage.TabIndex = 3;
            this.panelporderimage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelporderimage_Paint);
            // 
            // EditImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(978, 640);
            this.Controls.Add(this.panelporderimage);
            this.Controls.Add(this.paneldownControl);
            this.Controls.Add(this.panelRightcontrol);
            this.Controls.Add(this.panelToolControl);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditImage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditImage";
            this.Load += new System.EventHandler(this.EditImage_Load);
            this.panelToolControl.ResumeLayout(false);
            this.panelToolControl.PerformLayout();
            this.panelRightcontrol.ResumeLayout(false);
            this.panelRightcontrol.PerformLayout();
            this.panelMyimage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.paneldownControl.ResumeLayout(false);
            this.paneldownControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_bright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_hue)).EndInit();
            this.panelShowimage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelporderimage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolControl;
        private System.Windows.Forms.Button but_Close;
        private System.Windows.Forms.Panel panelRightcontrol;
        private System.Windows.Forms.Panel paneldownControl;
        private System.Windows.Forms.Button butNormal;
        private System.Windows.Forms.Button butCenter;
        private System.Windows.Forms.Button butAutoSize;
        private System.Windows.Forms.Button but_Stretch;
        private System.Windows.Forms.Button butZoom;
        private System.Windows.Forms.Button but_resize;
        private System.Windows.Forms.Button but_reload;
        private System.Windows.Forms.Button but_rotate;
        private System.Windows.Forms.Button but_f1;
        private System.Windows.Forms.Button but_f2;
        private System.Windows.Forms.Button but_f3;
        private System.Windows.Forms.Button but_f4;
        private System.Windows.Forms.Button but_f5;
        private System.Windows.Forms.Button butSelect_Image;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.TextBox text_Height;
        private System.Windows.Forms.TextBox text_Width;
        private System.Windows.Forms.TextBox txt_imgpath;
        private System.Windows.Forms.Panel panelShowimage;
        private System.Windows.Forms.Panel panelporderimage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelImagePath;
        private System.Windows.Forms.TrackBar trk_hue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelContrestbar;
        private System.Windows.Forms.Label labelHuebar;
        private System.Windows.Forms.TrackBar trk_bright;
        private System.Windows.Forms.TrackBar trk_Contrast;
        private System.Windows.Forms.Panel panelMyimage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
    }
}