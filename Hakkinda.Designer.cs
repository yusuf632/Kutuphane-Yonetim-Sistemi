
namespace Library
{
    partial class Hakkinda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hakkinda));
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAnaSayfaGeriDon = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kutuphane Yonetim Sistemi Hakkında";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(12, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(797, 423);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // btnAnaSayfaGeriDon
            // 
            this.btnAnaSayfaGeriDon.BackColor = System.Drawing.Color.Silver;
            this.btnAnaSayfaGeriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnaSayfaGeriDon.ForeColor = System.Drawing.Color.White;
            this.btnAnaSayfaGeriDon.Location = new System.Drawing.Point(12, 481);
            this.btnAnaSayfaGeriDon.Name = "btnAnaSayfaGeriDon";
            this.btnAnaSayfaGeriDon.Size = new System.Drawing.Size(275, 37);
            this.btnAnaSayfaGeriDon.TabIndex = 4;
            this.btnAnaSayfaGeriDon.Text = "Ana Sayfaya Geri Don";
            this.btnAnaSayfaGeriDon.UseVisualStyleBackColor = false;
            this.btnAnaSayfaGeriDon.Click += new System.EventHandler(this.btnAnaSayfaGeriDon_Click);
            this.btnAnaSayfaGeriDon.MouseEnter += new System.EventHandler(this.btnAnaSayfaGeriDon_MouseEnter);
            this.btnAnaSayfaGeriDon.MouseLeave += new System.EventHandler(this.btnAnaSayfaGeriDon_MouseLeave);
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.Silver;
            this.btnEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmail.ForeColor = System.Drawing.Color.White;
            this.btnEmail.Location = new System.Drawing.Point(622, 481);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(187, 37);
            this.btnEmail.TabIndex = 6;
            this.btnEmail.Text = "E-Posta";
            this.btnEmail.UseVisualStyleBackColor = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            this.btnEmail.MouseEnter += new System.EventHandler(this.btnEmail_MouseEnter);
            this.btnEmail.MouseLeave += new System.EventHandler(this.btnEmail_MouseLeave);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Hakkinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(821, 533);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnAnaSayfaGeriDon);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximumSize = new System.Drawing.Size(837, 572);
            this.MinimumSize = new System.Drawing.Size(837, 572);
            this.Name = "Hakkinda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hakkında";
            this.Load += new System.EventHandler(this.Hakkinda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAnaSayfaGeriDon;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}