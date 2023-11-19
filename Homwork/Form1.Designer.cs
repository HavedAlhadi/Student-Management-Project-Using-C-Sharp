namespace Homwork
{
    partial class notbad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notbad));
            this.btn_redo = new System.Windows.Forms.Button();
            this.txt_SelectLength = new System.Windows.Forms.TextBox();
            this.btn_paste = new System.Windows.Forms.Button();
            this.btn_cut = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.txt_Length = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_undo = new System.Windows.Forms.Button();
            this.txt_clipboard = new System.Windows.Forms.TextBox();
            this.txt_Main = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_redo
            // 
            this.btn_redo.BackColor = System.Drawing.Color.Transparent;
            this.btn_redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_redo.Font = new System.Drawing.Font("DecoType Naskh Variants", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_redo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_redo.Location = new System.Drawing.Point(122, 297);
            this.btn_redo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_redo.Name = "btn_redo";
            this.btn_redo.Size = new System.Drawing.Size(115, 47);
            this.btn_redo.TabIndex = 85;
            this.btn_redo.Text = "تراجع للأمام";
            this.btn_redo.UseVisualStyleBackColor = false;
            this.btn_redo.Click += new System.EventHandler(this.btn_redo_Click);
            // 
            // txt_SelectLength
            // 
            this.txt_SelectLength.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SelectLength.Location = new System.Drawing.Point(21, 263);
            this.txt_SelectLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SelectLength.Name = "txt_SelectLength";
            this.txt_SelectLength.ReadOnly = true;
            this.txt_SelectLength.Size = new System.Drawing.Size(190, 24);
            this.txt_SelectLength.TabIndex = 84;
            this.txt_SelectLength.TextChanged += new System.EventHandler(this.txt_SelectLength_TextChanged);
            // 
            // btn_paste
            // 
            this.btn_paste.BackColor = System.Drawing.Color.Transparent;
            this.btn_paste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paste.Font = new System.Drawing.Font("DecoType Naskh Variants", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_paste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_paste.Location = new System.Drawing.Point(332, 297);
            this.btn_paste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.Size = new System.Drawing.Size(116, 47);
            this.btn_paste.TabIndex = 82;
            this.btn_paste.Text = "لصق";
            this.btn_paste.UseVisualStyleBackColor = false;
            this.btn_paste.Click += new System.EventHandler(this.btn_paste_Click);
            // 
            // btn_cut
            // 
            this.btn_cut.BackColor = System.Drawing.Color.Transparent;
            this.btn_cut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cut.Font = new System.Drawing.Font("DecoType Naskh Variants", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_cut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cut.Location = new System.Drawing.Point(454, 297);
            this.btn_cut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cut.Name = "btn_cut";
            this.btn_cut.Size = new System.Drawing.Size(135, 47);
            this.btn_cut.TabIndex = 81;
            this.btn_cut.Text = "قص";
            this.btn_cut.UseVisualStyleBackColor = false;
            this.btn_cut.Click += new System.EventHandler(this.btn_cut_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.BackColor = System.Drawing.Color.Transparent;
            this.btn_copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copy.Font = new System.Drawing.Font("DecoType Naskh Variants", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_copy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_copy.Location = new System.Drawing.Point(595, 297);
            this.btn_copy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(145, 47);
            this.btn_copy.TabIndex = 80;
            this.btn_copy.Text = "نسخ";
            this.btn_copy.UseVisualStyleBackColor = false;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // txt_Length
            // 
            this.txt_Length.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Length.Location = new System.Drawing.Point(411, 263);
            this.txt_Length.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Length.Name = "txt_Length";
            this.txt_Length.ReadOnly = true;
            this.txt_Length.Size = new System.Drawing.Size(219, 24);
            this.txt_Length.TabIndex = 79;
            this.txt_Length.TextChanged += new System.EventHandler(this.txt_Length_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(203, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 78;
            this.label6.Text = "  طول النص المحدد";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(636, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = "طول النص\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_undo
            // 
            this.btn_undo.BackColor = System.Drawing.Color.Transparent;
            this.btn_undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_undo.Font = new System.Drawing.Font("DecoType Naskh Variants", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_undo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_undo.Location = new System.Drawing.Point(0, 297);
            this.btn_undo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(116, 47);
            this.btn_undo.TabIndex = 83;
            this.btn_undo.Text = "تراجع للخلف";
            this.btn_undo.UseVisualStyleBackColor = false;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // txt_clipboard
            // 
            this.txt_clipboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_clipboard.Location = new System.Drawing.Point(0, 207);
            this.txt_clipboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_clipboard.Multiline = true;
            this.txt_clipboard.Name = "txt_clipboard";
            this.txt_clipboard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_clipboard.Size = new System.Drawing.Size(752, 53);
            this.txt_clipboard.TabIndex = 76;
            this.txt_clipboard.TextChanged += new System.EventHandler(this.txt_clipboard_TextChanged);
            // 
            // txt_Main
            // 
            this.txt_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Main.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Main.Location = new System.Drawing.Point(0, 0);
            this.txt_Main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Main.Multiline = true;
            this.txt_Main.Name = "txt_Main";
            this.txt_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Main.Size = new System.Drawing.Size(752, 207);
            this.txt_Main.TabIndex = 75;
            this.txt_Main.Text = resources.GetString("txt_Main.Text");
            this.txt_Main.TextChanged += new System.EventHandler(this.txt_Main_TextChanged);
            this.txt_Main.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Main_KeyDown);
            this.txt_Main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Main_KeyUp);
            this.txt_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txt_Main_MouseUp);
            // 
            // notbad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(752, 357);
            this.Controls.Add(this.btn_redo);
            this.Controls.Add(this.txt_SelectLength);
            this.Controls.Add(this.btn_paste);
            this.Controls.Add(this.btn_cut);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.txt_Length);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_undo);
            this.Controls.Add(this.txt_clipboard);
            this.Controls.Add(this.txt_Main);
            this.Name = "notbad";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_redo;
        private System.Windows.Forms.TextBox txt_SelectLength;
        private System.Windows.Forms.Button btn_paste;
        private System.Windows.Forms.Button btn_cut;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.TextBox txt_Length;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_undo;
        private System.Windows.Forms.TextBox txt_clipboard;
        private System.Windows.Forms.TextBox txt_Main;
    }
}