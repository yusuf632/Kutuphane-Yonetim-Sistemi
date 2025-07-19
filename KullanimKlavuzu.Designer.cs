
namespace Library
{
    partial class KullanimKlavuzu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanimKlavuzu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnaSayfaGeriDon = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sisteme Giris Yardımı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(806, 456);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btnAnaSayfaGeriDon
            // 
            this.btnAnaSayfaGeriDon.BackColor = System.Drawing.Color.Silver;
            this.btnAnaSayfaGeriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnaSayfaGeriDon.ForeColor = System.Drawing.Color.White;
            this.btnAnaSayfaGeriDon.Location = new System.Drawing.Point(27, 523);
            this.btnAnaSayfaGeriDon.Name = "btnAnaSayfaGeriDon";
            this.btnAnaSayfaGeriDon.Size = new System.Drawing.Size(275, 37);
            this.btnAnaSayfaGeriDon.TabIndex = 3;
            this.btnAnaSayfaGeriDon.Text = "Ana Sayfaya Geri Don";
            this.btnAnaSayfaGeriDon.UseVisualStyleBackColor = false;
            this.btnAnaSayfaGeriDon.Click += new System.EventHandler(this.btnAnaSayfaGeriDon_Click);
            this.btnAnaSayfaGeriDon.MouseEnter += new System.EventHandler(this.btnAnaSayfaGeriDon_MouseEnter);
            this.btnAnaSayfaGeriDon.MouseLeave += new System.EventHandler(this.btnAnaSayfaGeriDon_MouseLeave);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // KullanimKlavuzu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(849, 576);
            this.Controls.Add(this.btnAnaSayfaGeriDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximumSize = new System.Drawing.Size(865, 615);
            this.MinimumSize = new System.Drawing.Size(865, 615);
            this.Name = "KullanimKlavuzu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanim Klavuzu";
            this.Load += new System.EventHandler(this.KullanimKlavuzu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnaSayfaGeriDon;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}