namespace Homwork
{
    partial class StudentPag
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textName = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.GroupBox();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Famle = new System.Windows.Forms.RadioButton();
            this.comboBoxstat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_secti = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colsex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_SaveDraw = new System.Windows.Forms.Button();
            this.comboBoxDrowing = new System.Windows.Forms.ComboBox();
            this.buttonEditimage = new System.Windows.Forms.Button();
            this.butAddimg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.Sex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.Sex);
            this.panel1.Controls.Add(this.comboBoxstat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.txt_secti);
            this.panel1.Location = new System.Drawing.Point(556, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 257);
            this.panel1.TabIndex = 34;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(75, 53);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(235, 32);
            this.textName.TabIndex = 45;
            this.textName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textName_KeyPress);
            // 
            // Sex
            // 
            this.Sex.Controls.Add(this.Male);
            this.Sex.Controls.Add(this.Famle);
            this.Sex.Font = new System.Drawing.Font("DecoType Naskh Extensions", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Sex.Location = new System.Drawing.Point(87, 80);
            this.Sex.Name = "Sex";
            this.Sex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sex.Size = new System.Drawing.Size(316, 89);
            this.Sex.TabIndex = 44;
            this.Sex.TabStop = false;
            this.Sex.Text = "نوع الجنس";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(180, 25);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(58, 47);
            this.Male.TabIndex = 1;
            this.Male.TabStop = true;
            this.Male.Text = "ذكر";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Famle
            // 
            this.Famle.AutoSize = true;
            this.Famle.Location = new System.Drawing.Point(49, 25);
            this.Famle.Name = "Famle";
            this.Famle.Size = new System.Drawing.Size(82, 47);
            this.Famle.TabIndex = 0;
            this.Famle.TabStop = true;
            this.Famle.Text = "أنثى";
            this.Famle.UseVisualStyleBackColor = true;
            // 
            // comboBoxstat
            // 
            this.comboBoxstat.FormattingEnabled = true;
            this.comboBoxstat.Items.AddRange(new object[] {
            "بكالاريوس",
            "ماجستر",
            "دكتوراة"});
            this.comboBoxstat.Location = new System.Drawing.Point(110, 175);
            this.comboBoxstat.Name = "comboBoxstat";
            this.comboBoxstat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxstat.Size = new System.Drawing.Size(212, 24);
            this.comboBoxstat.TabIndex = 43;
            this.comboBoxstat.Text = "الحالة الدراسية:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = ":رقم الطالب";
            // 
            // textNumber
            // 
            this.textNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumber.Location = new System.Drawing.Point(75, 15);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(235, 32);
            this.textNumber.TabIndex = 41;
            this.textNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = ":القسم";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(316, 53);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(118, 24);
            this.lbl_name.TabIndex = 39;
            this.lbl_name.Text = ":اسم الطالب";
            // 
            // txt_secti
            // 
            this.txt_secti.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_secti.Location = new System.Drawing.Point(87, 209);
            this.txt_secti.Name = "txt_secti";
            this.txt_secti.Size = new System.Drawing.Size(235, 32);
            this.txt_secti.TabIndex = 37;
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_del.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.Coral;
            this.btn_del.Location = new System.Drawing.Point(616, 277);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(145, 34);
            this.btn_del.TabIndex = 30;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Olive;
            this.btn_edit.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_edit.Location = new System.Drawing.Point(767, 277);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(134, 35);
            this.btn_edit.TabIndex = 29;
            this.btn_edit.Text = "Edite";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(913, 277);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(121, 35);
            this.btn_add.TabIndex = 28;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.aName,
            this.Colsex,
            this.stat,
            this.section,
            this.st_img});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 218);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // aName
            // 
            this.aName.HeaderText = "Name";
            this.aName.MinimumWidth = 6;
            this.aName.Name = "aName";
            this.aName.ReadOnly = true;
            // 
            // Colsex
            // 
            this.Colsex.HeaderText = "Sex";
            this.Colsex.MinimumWidth = 6;
            this.Colsex.Name = "Colsex";
            this.Colsex.ReadOnly = true;
            // 
            // stat
            // 
            this.stat.HeaderText = "statu";
            this.stat.MinimumWidth = 6;
            this.stat.Name = "stat";
            this.stat.ReadOnly = true;
            // 
            // section
            // 
            this.section.HeaderText = "Section";
            this.section.MinimumWidth = 6;
            this.section.Name = "section";
            this.section.ReadOnly = true;
            // 
            // st_img
            // 
            this.st_img.HeaderText = "St_img";
            this.st_img.MinimumWidth = 6;
            this.st_img.Name = "st_img";
            this.st_img.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.but_SaveDraw);
            this.groupBox1.Controls.Add(this.comboBoxDrowing);
            this.groupBox1.Controls.Add(this.buttonEditimage);
            this.groupBox1.Controls.Add(this.butAddimg);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(531, 302);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "صورة الطالب:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // but_SaveDraw
            // 
            this.but_SaveDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_SaveDraw.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_SaveDraw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_SaveDraw.Location = new System.Drawing.Point(121, 257);
            this.but_SaveDraw.Name = "but_SaveDraw";
            this.but_SaveDraw.Size = new System.Drawing.Size(98, 34);
            this.but_SaveDraw.TabIndex = 47;
            this.but_SaveDraw.Text = "Save";
            this.but_SaveDraw.UseVisualStyleBackColor = false;
            this.but_SaveDraw.Click += new System.EventHandler(this.but_SaveDraw_Click);
            // 
            // comboBoxDrowing
            // 
            this.comboBoxDrowing.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.comboBoxDrowing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxDrowing.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDrowing.ForeColor = System.Drawing.Color.White;
            this.comboBoxDrowing.FormattingEnabled = true;
            this.comboBoxDrowing.Items.AddRange(new object[] {
            "Draw Sin",
            "Draw Cos",
            "Clear"});
            this.comboBoxDrowing.Location = new System.Drawing.Point(233, 259);
            this.comboBoxDrowing.Name = "comboBoxDrowing";
            this.comboBoxDrowing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxDrowing.Size = new System.Drawing.Size(159, 30);
            this.comboBoxDrowing.TabIndex = 46;
            this.comboBoxDrowing.Text = "Draw Image";
            this.comboBoxDrowing.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonEditimage
            // 
            this.buttonEditimage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEditimage.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditimage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEditimage.Location = new System.Drawing.Point(6, 257);
            this.buttonEditimage.Name = "buttonEditimage";
            this.buttonEditimage.Size = new System.Drawing.Size(98, 34);
            this.buttonEditimage.TabIndex = 41;
            this.buttonEditimage.Text = "Edite";
            this.buttonEditimage.UseVisualStyleBackColor = false;
            this.buttonEditimage.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // butAddimg
            // 
            this.butAddimg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butAddimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAddimg.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddimg.ForeColor = System.Drawing.Color.White;
            this.butAddimg.Location = new System.Drawing.Point(404, 257);
            this.butAddimg.Name = "butAddimg";
            this.butAddimg.Size = new System.Drawing.Size(121, 34);
            this.butAddimg.TabIndex = 40;
            this.butAddimg.Text = "Select Image";
            this.butAddimg.UseVisualStyleBackColor = false;
            this.butAddimg.Click += new System.EventHandler(this.butAddimg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // StudentPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentPag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPag";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Sex.ResumeLayout(false);
            this.Sex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn aName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colsex;
        private System.Windows.Forms.DataGridViewTextBoxColumn stat;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_img;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.GroupBox Sex;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Famle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_secti;
        private System.Windows.Forms.ComboBox comboBoxstat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEditimage;
        private System.Windows.Forms.Button butAddimg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxDrowing;
        private System.Windows.Forms.Button but_SaveDraw;
    }
}