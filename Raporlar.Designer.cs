
namespace Library
{
    partial class Raporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUyeler = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnTeslimEtmeyenler = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emanetlerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emanetTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıadeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimEdildiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emanetlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneYonetimDataSet2 = new Library.KutuphaneYonetimDataSet2();
            this.emanetlerTableAdapter = new Library.KutuphaneYonetimDataSet2TableAdapters.EmanetlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneYonetimDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Uye Adi:";
            // 
            // cmbUyeler
            // 
            this.cmbUyeler.FormattingEnabled = true;
            this.cmbUyeler.Location = new System.Drawing.Point(146, 299);
            this.cmbUyeler.Name = "cmbUyeler";
            this.cmbUyeler.Size = new System.Drawing.Size(259, 29);
            this.cmbUyeler.TabIndex = 40;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Silver;
            this.btnListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListele.ForeColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(16, 350);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(128, 49);
            this.btnListele.TabIndex = 48;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            this.btnListele.MouseEnter += new System.EventHandler(this.btnListele_MouseEnter);
            this.btnListele.MouseLeave += new System.EventHandler(this.btnListele_MouseLeave);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Silver;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(431, 350);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(128, 49);
            this.btnKapat.TabIndex = 51;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            this.btnKapat.MouseEnter += new System.EventHandler(this.btnKapat_MouseEnter);
            this.btnKapat.MouseLeave += new System.EventHandler(this.btnKapat_MouseLeave);
            // 
            // btnTeslimEtmeyenler
            // 
            this.btnTeslimEtmeyenler.BackColor = System.Drawing.Color.Silver;
            this.btnTeslimEtmeyenler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeslimEtmeyenler.ForeColor = System.Drawing.Color.White;
            this.btnTeslimEtmeyenler.Location = new System.Drawing.Point(180, 350);
            this.btnTeslimEtmeyenler.Name = "btnTeslimEtmeyenler";
            this.btnTeslimEtmeyenler.Size = new System.Drawing.Size(214, 49);
            this.btnTeslimEtmeyenler.TabIndex = 52;
            this.btnTeslimEtmeyenler.Text = "Teslim Etmeyenler";
            this.btnTeslimEtmeyenler.UseVisualStyleBackColor = false;
            this.btnTeslimEtmeyenler.Click += new System.EventHandler(this.btnTeslimEtmeyenler_Click);
            this.btnTeslimEtmeyenler.MouseEnter += new System.EventHandler(this.btnTeslimEtmeyenler_MouseEnter);
            this.btnTeslimEtmeyenler.MouseLeave += new System.EventHandler(this.btnTeslimEtmeyenler_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emanetlerIDDataGridViewTextBoxColumn,
            this.kitapIDDataGridViewTextBoxColumn,
            this.uyeIDDataGridViewTextBoxColumn,
            this.emanetTarihiDataGridViewTextBoxColumn,
            this.ıadeTarihiDataGridViewTextBoxColumn,
            this.teslimEdildiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.emanetlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 263);
            this.dataGridView1.TabIndex = 53;
            // 
            // emanetlerIDDataGridViewTextBoxColumn
            // 
            this.emanetlerIDDataGridViewTextBoxColumn.DataPropertyName = "EmanetlerID";
            this.emanetlerIDDataGridViewTextBoxColumn.HeaderText = "EmanetlerID";
            this.emanetlerIDDataGridViewTextBoxColumn.Name = "emanetlerIDDataGridViewTextBoxColumn";
            this.emanetlerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitapIDDataGridViewTextBoxColumn
            // 
            this.kitapIDDataGridViewTextBoxColumn.DataPropertyName = "KitapID";
            this.kitapIDDataGridViewTextBoxColumn.HeaderText = "KitapID";
            this.kitapIDDataGridViewTextBoxColumn.Name = "kitapIDDataGridViewTextBoxColumn";
            // 
            // uyeIDDataGridViewTextBoxColumn
            // 
            this.uyeIDDataGridViewTextBoxColumn.DataPropertyName = "UyeID";
            this.uyeIDDataGridViewTextBoxColumn.HeaderText = "UyeID";
            this.uyeIDDataGridViewTextBoxColumn.Name = "uyeIDDataGridViewTextBoxColumn";
            // 
            // emanetTarihiDataGridViewTextBoxColumn
            // 
            this.emanetTarihiDataGridViewTextBoxColumn.DataPropertyName = "EmanetTarihi";
            this.emanetTarihiDataGridViewTextBoxColumn.HeaderText = "EmanetTarihi";
            this.emanetTarihiDataGridViewTextBoxColumn.Name = "emanetTarihiDataGridViewTextBoxColumn";
            // 
            // ıadeTarihiDataGridViewTextBoxColumn
            // 
            this.ıadeTarihiDataGridViewTextBoxColumn.DataPropertyName = "IadeTarihi";
            this.ıadeTarihiDataGridViewTextBoxColumn.HeaderText = "IadeTarihi";
            this.ıadeTarihiDataGridViewTextBoxColumn.Name = "ıadeTarihiDataGridViewTextBoxColumn";
            // 
            // teslimEdildiDataGridViewTextBoxColumn
            // 
            this.teslimEdildiDataGridViewTextBoxColumn.DataPropertyName = "TeslimEdildi";
            this.teslimEdildiDataGridViewTextBoxColumn.HeaderText = "TeslimEdildi";
            this.teslimEdildiDataGridViewTextBoxColumn.Name = "teslimEdildiDataGridViewTextBoxColumn";
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
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(591, 424);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTeslimEtmeyenler);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUyeler);
            this.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximumSize = new System.Drawing.Size(607, 463);
            this.MinimumSize = new System.Drawing.Size(607, 463);
            this.Name = "Raporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.Raporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneYonetimDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUyeler;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnTeslimEtmeyenler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KutuphaneYonetimDataSet2 kutuphaneYonetimDataSet2;
        private System.Windows.Forms.BindingSource emanetlerBindingSource;
        private KutuphaneYonetimDataSet2TableAdapters.EmanetlerTableAdapter emanetlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn emanetlerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emanetTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıadeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimEdildiDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}