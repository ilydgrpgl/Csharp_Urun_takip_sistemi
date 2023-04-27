namespace UrunTakip
{
    partial class frmurun
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Cmbkategori = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txtıd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtalis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtsatis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnsil = new System.Windows.Forms.Button();
            this.Btnguncelle = new System.Windows.Forms.Button();
            this.Btnlistele = new System.Windows.Forms.Button();
            this.Btnkaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 451);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.Cmbkategori);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Txtıd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Txtalis);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txtsatis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txtad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(810, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 260);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(169, 81);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 28);
            this.numericUpDown1.TabIndex = 9;
            // 
            // Cmbkategori
            // 
            this.Cmbkategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbkategori.FormattingEnabled = true;
            this.Cmbkategori.Location = new System.Drawing.Point(166, 192);
            this.Cmbkategori.Name = "Cmbkategori";
            this.Cmbkategori.Size = new System.Drawing.Size(121, 30);
            this.Cmbkategori.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Stok:";
            // 
            // Txtıd
            // 
            this.Txtıd.Location = new System.Drawing.Point(169, 13);
            this.Txtıd.Name = "Txtıd";
            this.Txtıd.Size = new System.Drawing.Size(118, 28);
            this.Txtıd.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ürün ID:";
            // 
            // Txtalis
            // 
            this.Txtalis.Location = new System.Drawing.Point(169, 114);
            this.Txtalis.Name = "Txtalis";
            this.Txtalis.Size = new System.Drawing.Size(118, 28);
            this.Txtalis.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Alış Fiyatı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kategori :";
            // 
            // Txtsatis
            // 
            this.Txtsatis.Location = new System.Drawing.Point(169, 152);
            this.Txtsatis.Name = "Txtsatis";
            this.Txtsatis.Size = new System.Drawing.Size(118, 28);
            this.Txtsatis.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Satış Fiyatı:";
            // 
            // Txtad
            // 
            this.Txtad.Location = new System.Drawing.Point(169, 47);
            this.Txtad.Name = "Txtad";
            this.Txtad.Size = new System.Drawing.Size(118, 28);
            this.Txtad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün adı:";
            // 
            // Btnsil
            // 
            this.Btnsil.Location = new System.Drawing.Point(855, 346);
            this.Btnsil.Name = "Btnsil";
            this.Btnsil.Size = new System.Drawing.Size(104, 42);
            this.Btnsil.TabIndex = 5;
            this.Btnsil.Text = "Sil";
            this.Btnsil.UseVisualStyleBackColor = true;
            this.Btnsil.Click += new System.EventHandler(this.Btnsil_Click);
            // 
            // Btnguncelle
            // 
            this.Btnguncelle.Location = new System.Drawing.Point(979, 346);
            this.Btnguncelle.Name = "Btnguncelle";
            this.Btnguncelle.Size = new System.Drawing.Size(104, 42);
            this.Btnguncelle.TabIndex = 6;
            this.Btnguncelle.Text = "Güncelle";
            this.Btnguncelle.UseVisualStyleBackColor = true;
            this.Btnguncelle.Click += new System.EventHandler(this.Btnguncelle_Click);
            // 
            // Btnlistele
            // 
            this.Btnlistele.Location = new System.Drawing.Point(855, 298);
            this.Btnlistele.Name = "Btnlistele";
            this.Btnlistele.Size = new System.Drawing.Size(104, 42);
            this.Btnlistele.TabIndex = 7;
            this.Btnlistele.Text = "Listele";
            this.Btnlistele.UseVisualStyleBackColor = true;
            this.Btnlistele.Click += new System.EventHandler(this.Btnlistele_Click);
            // 
            // Btnkaydet
            // 
            this.Btnkaydet.Location = new System.Drawing.Point(979, 298);
            this.Btnkaydet.Name = "Btnkaydet";
            this.Btnkaydet.Size = new System.Drawing.Size(104, 42);
            this.Btnkaydet.TabIndex = 8;
            this.Btnkaydet.Text = "Kaydet";
            this.Btnkaydet.UseVisualStyleBackColor = true;
            this.Btnkaydet.Click += new System.EventHandler(this.Btnkaydet_Click);
            // 
            // frmurun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1159, 453);
            this.Controls.Add(this.Btnkaydet);
            this.Controls.Add(this.Btnlistele);
            this.Controls.Add(this.Btnguncelle);
            this.Controls.Add(this.Btnsil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmurun";
            this.Text = "ürün";
            this.Load += new System.EventHandler(this.frmurun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txtad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnsil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txtıd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtalis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtsatis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btnguncelle;
        private System.Windows.Forms.Button Btnlistele;
        private System.Windows.Forms.Button Btnkaydet;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox Cmbkategori;
    }
}