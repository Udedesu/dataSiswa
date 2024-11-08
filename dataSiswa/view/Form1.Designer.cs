namespace dataSiswa
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Table_data = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_Simpan = new System.Windows.Forms.Button();
            this.Nohp = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nik = new System.Windows.Forms.TextBox();
            this.Nama_l = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cari_data = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_data)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Table_data);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1468, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Data Siswa";
            // 
            // Table_data
            // 
            this.Table_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table_data.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Table_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_data.Location = new System.Drawing.Point(6, 25);
            this.Table_data.Name = "Table_data";
            this.Table_data.RowHeadersWidth = 62;
            this.Table_data.RowTemplate.Height = 28;
            this.Table_data.Size = new System.Drawing.Size(1456, 190);
            this.Table_data.TabIndex = 0;
            this.Table_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_data_CellClick);
            this.Table_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_data_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_hapus);
            this.groupBox2.Controls.Add(this.btn_ubah);
            this.groupBox2.Controls.Add(this.btn_Simpan);
            this.groupBox2.Controls.Add(this.Nohp);
            this.groupBox2.Controls.Add(this.Email);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Nik);
            this.groupBox2.Controls.Add(this.Nama_l);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(875, 404);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "From Siswa";
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_hapus.Location = new System.Drawing.Point(20, 325);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(834, 67);
            this.btn_hapus.TabIndex = 12;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_ubah.Location = new System.Drawing.Point(20, 239);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(834, 67);
            this.btn_ubah.TabIndex = 11;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.UseVisualStyleBackColor = false;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_Simpan
            // 
            this.btn_Simpan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Simpan.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Simpan.Location = new System.Drawing.Point(20, 157);
            this.btn_Simpan.Name = "btn_Simpan";
            this.btn_Simpan.Size = new System.Drawing.Size(834, 67);
            this.btn_Simpan.TabIndex = 10;
            this.btn_Simpan.Text = "Simpan";
            this.btn_Simpan.UseVisualStyleBackColor = false;
            this.btn_Simpan.Click += new System.EventHandler(this.btn_Simpan_Click);
            // 
            // Nohp
            // 
            this.Nohp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Nohp.Location = new System.Drawing.Point(496, 98);
            this.Nohp.Name = "Nohp";
            this.Nohp.Size = new System.Drawing.Size(236, 30);
            this.Nohp.TabIndex = 9;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Email.Location = new System.Drawing.Point(496, 36);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(236, 30);
            this.Email.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(417, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "No Hp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(417, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // Nik
            // 
            this.Nik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Nik.Location = new System.Drawing.Point(102, 98);
            this.Nik.Name = "Nik";
            this.Nik.Size = new System.Drawing.Size(236, 30);
            this.Nik.TabIndex = 5;
            // 
            // Nama_l
            // 
            this.Nama_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Nama_l.Location = new System.Drawing.Point(102, 40);
            this.Nama_l.Name = "Nama_l";
            this.Nama_l.Size = new System.Drawing.Size(236, 30);
            this.Nama_l.TabIndex = 4;
            this.Nama_l.TextChanged += new System.EventHandler(this.Nama_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(16, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nik:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cari_data);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(899, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(581, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "From Pencarian";
            // 
            // Cari_data
            // 
            this.Cari_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cari_data.Location = new System.Drawing.Point(161, 39);
            this.Cari_data.Name = "Cari_data";
            this.Cari_data.Size = new System.Drawing.Size(355, 30);
            this.Cari_data.TabIndex = 11;
            this.Cari_data.TextChanged += new System.EventHandler(this.Cari_data_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(36, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cari Data:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1486, 668);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Data Siswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Table_data)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Nik;
        private System.Windows.Forms.TextBox Nama_l;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_Simpan;
        private System.Windows.Forms.TextBox Nohp;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Cari_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Table_data;
    }
}

