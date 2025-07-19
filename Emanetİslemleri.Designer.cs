
namespace Library
{
    partial class Emanetİslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emanetİslemleri));
            this.cmbKitaplar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUyeler = new System.Windows.Forms.ComboBox();
            this.dtpEmanetTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpIadeTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.btnTeslimAl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emanetlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneYonetimDataSet2 = new Library.KutuphaneYonetimDataSet2();
            this.kutuphaneYonetimDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emanetlerTableAdapter = new Library.KutuphaneYonetimDataSet2TableAdapters.EmanetlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneYonetimDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneYonetimDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKitaplar
            // 
            this.cmbKitaplar.FormattingEnabled = true;
            this.cmbKitaplar.Location = new System.Drawing.Point(173, 225);
            this.cmbKitaplar.Name = "cmbKitaplar";
            this.cmbKitaplar.Size = new System.Drawing.Size(200, 29);
            this.cmbKitaplar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Kitap Adi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Uye Adi:";
            // 
            // cmbUyeler
            // 
            this.cmbUyeler.FormattingEnabled = true;
            this.cmbUyeler.Location = new System.Drawing.Point(173, 279);
            this.cmbUyeler.Name = "cmbUyeler";
            this.cmbUyeler.Size = new System.Drawing.Size(200, 29);
            this.cmbUyeler.TabIndex = 1;
            // 
            // dtpEmanetTarihi
            // 
            this.dtpEmanetTarihi.Location = new System.Drawing.Point(173, 332);
            this.dtpEmanetTarihi.Name = "dtpEmanetTarihi";
            this.dtpEmanetTarihi.Size = new System.Drawing.Size(200, 29);
            this.dtpEmanetTarihi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Emanet Tarihi:";
            // 
            // dtpIadeTarihi
            // 
            this.dtpIadeTarihi.Location = new System.Drawing.Point(173, 384);
            this.dtpIadeTarihi.Name = "dtpIadeTarihi";
            this.dtpIadeTarihi.Size = new System.Drawing.Size(200, 29);
            this.dtpIadeTarihi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 42;
            this.label5.Text = "Iade Tarihi:";
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.BackColor = System.Drawing.Color.Silver;
            this.btnEmanetVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetVer.ForeColor = System.Drawing.Color.White;
            this.btnEmanetVer.Location = new System.Drawing.Point(426, 225);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(212, 49);
            this.btnEmanetVer.TabIndex = 44;
            this.btnEmanetVer.Text = "Emanet Et";
            this.btnEmanetVer.UseVisualStyleBackColor = false;
            this.btnEmanetVer.Click += new System.EventHandler(this.btnEmanetVer_Click);
            this.btnEmanetVer.MouseEnter += new System.EventHandler(this.btnEmanetVer_MouseEnter);
            this.btnEmanetVer.MouseLeave += new System.EventHandler(this.btnEmanetVer_MouseLeave);
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.BackColor = System.Drawing.Color.Silver;
            this.btnTeslimAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeslimAl.ForeColor = System.Drawing.Color.White;
            this.btnTeslimAl.Location = new System.Drawing.Point(426, 296);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(212, 49);
            this.btnTeslimAl.TabIndex = 46;
            this.btnTeslimAl.Text = "Emanet Al";
            this.btnTeslimAl.UseVisualStyleBackColor = false;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            this.btnTeslimAl.MouseEnter += new System.EventHandler(this.btnTeslimAl_MouseEnter);
            this.btnTeslimAl.MouseLeave += new System.EventHandler(this.btnTeslimAl_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(113, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Ara:";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(173, 429);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(200, 29);
            this.txtArama.TabIndex = 4;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Silver;
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(173, 477);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(200, 49);
            this.btnAra.TabIndex = 47;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            this.btnAra.MouseEnter += new System.EventHandler(this.btnAra_MouseEnter);
            this.btnAra.MouseLeave += new System.EventHandler(this.btnAra_MouseLeave);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Silver;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(426, 364);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(212, 49);
            this.btnKapat.TabIndex = 50;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            this.btnKapat.MouseEnter += new System.EventHandler(this.btnKapat_MouseEnter);
            this.btnKapat.MouseLeave += new System.EventHandler(this.btnKapat_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.emanetlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 191);
            this.dataGridView1.TabIndex = 51;
            // 
            // emanetlerBindingSource
            // 
            this.emanetlerBindingSource.DataMember = "Emanetler";
            this.emanetlerBindingSource.DataSource = this.kutuphaneYonetimDataSet2;
            // 
            // kutuphaneYonetimDataSet2
            // 
            this.kutuphaneYonetimDataSet2.DataSetName = "KutuphaneYonetimDataSet2";
            this.kutuphaneYonetimDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kutuphaneYonetimDataSet2BindingSource
            // 
            this.kutuphaneYonetimDataSet2BindingSource.DataSource = this.kutuphaneYonetimDataSet2;
            this.kutuphaneYonetimDataSet2BindingSource.Position = 0;
            // 
            // emanetlerTableAdapter
            // 
            this.emanetlerTableAdapter.ClearBeforeFill = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Emanetİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(679, 538);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnTeslimAl);
            this.Controls.Add(this.btnEmanetVer);
            this.Controls.Add(this.dtpIadeTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpEmanetTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUyeler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKitaplar);
            this.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "Emanetİslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet İşlemleri";
            this.Load += new System.EventHandler(this.Emanetİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneYonetimDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneYonetimDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKitaplar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUyeler;
        private System.Windows.Forms.DateTimePicker dtpEmanetTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpIadeTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEmanetVer;
        private System.Windows.Forms.Button btnTeslimAl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kutuphaneYonetimDataSet2BindingSource;
        private KutuphaneYonetimDataSet2 kutuphaneYonetimDataSet2;
        private System.Windows.Forms.BindingSource emanetlerBindingSource;
        private KutuphaneYonetimDataSet2TableAdapters.EmanetlerTableAdapter emanetlerTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}