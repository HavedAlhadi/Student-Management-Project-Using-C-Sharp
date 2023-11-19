namespace Homwork
{
    partial class Homwork2
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
            this.labOk = new System.Windows.Forms.Label();
            this.butnback1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labOk
            // 
            this.labOk.AutoSize = true;
            this.labOk.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labOk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labOk.Font = new System.Drawing.Font("DecoType Naskh Variants", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labOk.ForeColor = System.Drawing.SystemColors.Control;
            this.labOk.Location = new System.Drawing.Point(211, 302);
            this.labOk.Name = "labOk";
            this.labOk.Size = new System.Drawing.Size(186, 64);
            this.labOk.TabIndex = 0;
            this.labOk.Text = "تم تغيير خلفية الفورم";
            this.labOk.Click += new System.EventHandler(this.label1_Click);
            // 
            // butnback1
            // 
            this.butnback1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butnback1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butnback1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butnback1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butnback1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnback1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butnback1.Location = new System.Drawing.Point(22, 528);
            this.butnback1.Name = "butnback1";
            this.butnback1.Size = new System.Drawing.Size(123, 47);
            this.butnback1.TabIndex = 1;
            this.butnback1.Text = "Back";
            this.butnback1.UseVisualStyleBackColor = false;
            this.butnback1.Click += new System.EventHandler(this.butnback1_Click);
            // 
            // Homwork2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homwork.Properties.Resources._20210304_233034;
            this.ClientSize = new System.Drawing.Size(758, 609);
            this.Controls.Add(this.butnback1);
            this.Controls.Add(this.labOk);
            this.Name = "Homwork2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labOk;
        private System.Windows.Forms.Button butnback1;
    }
}