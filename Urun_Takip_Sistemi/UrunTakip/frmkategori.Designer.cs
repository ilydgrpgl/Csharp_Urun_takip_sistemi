namespace UrunTakip
{
    partial class frmkategori
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.Txtad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnlistele = new System.Windows.Forms.Button();
            this.Btnkaydet = new System.Windows.Forms.Button();
            this.Btnsil = new System.Windows.Forms.Button();
            this.Btngüncelle = new System.Windows.Forms.Button();
            this.Btnara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(351, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.Txtad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(362, 32);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(103, 22);
            this.TxtID.TabIndex = 2;
            // 
            // Txtad
            // 
            this.Txtad.Location = new System.Drawing.Point(97, 32);
            this.Txtad.Name = "Txtad";
            this.Txtad.Size = new System.Drawing.Size(217, 22);
            this.Txtad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori adı:";
            // 
            // Btnlistele
            // 
            this.Btnlistele.Location = new System.Drawing.Point(379, 95);
            this.Btnlistele.Name = "Btnlistele";
            this.Btnlistele.Size = new System.Drawing.Size(104, 42);
            this.Btnlistele.TabIndex = 2;
            this.Btnlistele.Text = "Listele";
            this.Btnlistele.UseVisualStyleBackColor = true;
            this.Btnlistele.Click += new System.EventHandler(this.Btnlistele_Click);
            // 
            // Btnkaydet
            // 
            this.Btnkaydet.Location = new System.Drawing.Point(379, 152);
            this.Btnkaydet.Name = "Btnkaydet";
            this.Btnkaydet.Size = new System.Drawing.Size(104, 42);
            this.Btnkaydet.TabIndex = 3;
            this.Btnkaydet.Text = "Kaydet";
            this.Btnkaydet.UseVisualStyleBackColor = true;
            this.Btnkaydet.Click += new System.EventHandler(this.Btnkaydet_Click);
            // 
            // Btnsil
            // 
            this.Btnsil.Location = new System.Drawing.Point(379, 217);
            this.Btnsil.Name = "Btnsil";
            this.Btnsil.Size = new System.Drawing.Size(104, 42);
            this.Btnsil.TabIndex = 4;
            this.Btnsil.Text = "Sil";
            this.Btnsil.UseVisualStyleBackColor = true;
            this.Btnsil.Click += new System.EventHandler(this.Btnsil_Click);
            // 
            // Btngüncelle
            // 
            this.Btngüncelle.Location = new System.Drawing.Point(379, 279);
            this.Btngüncelle.Name = "Btngüncelle";
            this.Btngüncelle.Size = new System.Drawing.Size(104, 42);
            this.Btngüncelle.TabIndex = 5;
            this.Btngüncelle.Text = "Güncelle";
            this.Btngüncelle.UseVisualStyleBackColor = true;
            this.Btngüncelle.Click += new System.EventHandler(this.Btngüncelle_Click);
            // 
            // Btnara
            // 
            this.Btnara.Location = new System.Drawing.Point(379, 349);
            this.Btnara.Name = "Btnara";
            this.Btnara.Size = new System.Drawing.Size(104, 42);
            this.Btnara.TabIndex = 6;
            this.Btnara.Text = "Ara";
            this.Btnara.UseVisualStyleBackColor = true;
            this.Btnara.Click += new System.EventHandler(this.Btnara_Click);
            // 
            // frmkategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(543, 406);
            this.Controls.Add(this.Btnara);
            this.Controls.Add(this.Btngüncelle);
            this.Controls.Add(this.Btnsil);
            this.Controls.Add(this.Btnkaydet);
            this.Controls.Add(this.Btnlistele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmkategori";
            this.Text = "kategori";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txtad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnlistele;
        private System.Windows.Forms.Button Btnkaydet;
        private System.Windows.Forms.Button Btnsil;
        private System.Windows.Forms.Button Btngüncelle;
        private System.Windows.Forms.Button Btnara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtID;
    }
}

