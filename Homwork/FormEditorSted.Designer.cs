namespace Homwork
{
    partial class FormEditorSted
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
            this.paneleditorsted = new System.Windows.Forms.Panel();
            this.textName = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.GroupBox();
            this.Male1 = new System.Windows.Forms.RadioButton();
            this.Famle1 = new System.Windows.Forms.RadioButton();
            this.comboBoxstat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNumber1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_secti = new System.Windows.Forms.TextBox();
            this.pictureBoxeditor = new System.Windows.Forms.PictureBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.butAddimg = new System.Windows.Forms.Button();
            this.paneleditorsted.SuspendLayout();
            this.Sex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxeditor)).BeginInit();
            this.SuspendLayout();
            // 
            // paneleditorsted
            // 
            this.paneleditorsted.BackColor = System.Drawing.Color.DarkKhaki;
            this.paneleditorsted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneleditorsted.Controls.Add(this.textName);
            this.paneleditorsted.Controls.Add(this.Sex);
            this.paneleditorsted.Controls.Add(this.comboBoxstat);
            this.paneleditorsted.Controls.Add(this.label4);
            this.paneleditorsted.Controls.Add(this.textNumber1);
            this.paneleditorsted.Controls.Add(this.label1);
            this.paneleditorsted.Controls.Add(this.label2);
            this.paneleditorsted.Controls.Add(this.lbl_name);
            this.paneleditorsted.Controls.Add(this.txt_secti);
            this.paneleditorsted.Location = new System.Drawing.Point(42, 329);
            this.paneleditorsted.Name = "paneleditorsted";
            this.paneleditorsted.Size = new System.Drawing.Size(443, 257);
            this.paneleditorsted.TabIndex = 36;
            this.paneleditorsted.Paint += new System.Windows.Forms.PaintEventHandler(this.paneleditorsted_Paint);
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(75, 53);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(235, 32);
            this.textName.TabIndex = 45;
            // 
            // Sex
            // 
            this.Sex.Controls.Add(this.Male1);
            this.Sex.Controls.Add(this.Famle1);
            this.Sex.Font = new System.Drawing.Font("DecoType Naskh Extensions", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Sex.Location = new System.Drawing.Point(87, 80);
            this.Sex.Name = "Sex";
            this.Sex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sex.Size = new System.Drawing.Size(316, 89);
            this.Sex.TabIndex = 44;
            this.Sex.TabStop = false;
            this.Sex.Text = "نوع الجنس";
            // 
            // Male1
            // 
            this.Male1.AutoSize = true;
            this.Male1.Location = new System.Drawing.Point(180, 25);
            this.Male1.Name = "Male1";
            this.Male1.Size = new System.Drawing.Size(58, 47);
            this.Male1.TabIndex = 1;
            this.Male1.TabStop = true;
            this.Male1.Text = "ذكر";
            this.Male1.UseVisualStyleBackColor = true;
            // 
            // Famle1
            // 
            this.Famle1.AutoSize = true;
            this.Famle1.Location = new System.Drawing.Point(49, 25);
            this.Famle1.Name = "Famle1";
            this.Famle1.Size = new System.Drawing.Size(82, 47);
            this.Famle1.TabIndex = 0;
            this.Famle1.TabStop = true;
            this.Famle1.Text = "أنثى";
            this.Famle1.UseVisualStyleBackColor = true;
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
            // textNumber1
            // 
            this.textNumber1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumber1.Location = new System.Drawing.Point(75, 15);
            this.textNumber1.Name = "textNumber1";
            this.textNumber1.Size = new System.Drawing.Size(235, 32);
            this.textNumber1.TabIndex = 41;
            this.textNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumber1_KeyPress);
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
            // pictureBoxeditor
            // 
            this.pictureBoxeditor.Location = new System.Drawing.Point(42, 15);
            this.pictureBoxeditor.Name = "pictureBoxeditor";
            this.pictureBoxeditor.Size = new System.Drawing.Size(440, 266);
            this.pictureBoxeditor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxeditor.TabIndex = 35;
            this.pictureBoxeditor.TabStop = false;
            this.pictureBoxeditor.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Olive;
            this.btn_edit.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_edit.Location = new System.Drawing.Point(180, 590);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(140, 52);
            this.btn_edit.TabIndex = 37;
            this.btn_edit.Text = "Edite";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // butAddimg
            // 
            this.butAddimg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
            this.butAddimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAddimg.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddimg.Location = new System.Drawing.Point(180, 284);
            this.butAddimg.Name = "butAddimg";
            this.butAddimg.Size = new System.Drawing.Size(140, 41);
            this.butAddimg.TabIndex = 46;
            this.butAddimg.Text = "Select Image";
            this.butAddimg.UseVisualStyleBackColor = false;
            this.butAddimg.Click += new System.EventHandler(this.butAddimg_Click);
            // 
            // FormEditorSted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(520, 663);
            this.Controls.Add(this.butAddimg);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.paneleditorsted);
            this.Controls.Add(this.pictureBoxeditor);
            this.Name = "FormEditorSted";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات الطالب";
            this.Load += new System.EventHandler(this.FormEditorSted_Load);
            this.paneleditorsted.ResumeLayout(false);
            this.paneleditorsted.PerformLayout();
            this.Sex.ResumeLayout(false);
            this.Sex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxeditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneleditorsted;
        private System.Windows.Forms.GroupBox Sex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button butAddimg;
        public System.Windows.Forms.TextBox textNumber1;
        public System.Windows.Forms.PictureBox pictureBoxeditor;
        public System.Windows.Forms.TextBox textName;
        public System.Windows.Forms.RadioButton Male1;
        public System.Windows.Forms.RadioButton Famle1;
        public System.Windows.Forms.ComboBox comboBoxstat;
        public System.Windows.Forms.TextBox txt_secti;
    }
}