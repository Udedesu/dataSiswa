using dataSiswa.controller;
using dataSiswa.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataSiswa
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        siswa_m siswa = new siswa_m();
        string id;
        public void Tampil()
        {
            //Query SQL
            Table_data.DataSource = koneksi.ShowData("SELECT * FROM siswa");

            //Ubah nama tampilan table
            Table_data.Columns[0].HeaderText = "No";
            Table_data.Columns[1].HeaderText = "Nama Siswa";
            Table_data.Columns[2].HeaderText = "NIK";
            Table_data.Columns[3].HeaderText = "Email";
            Table_data.Columns[4].HeaderText = "Nomor HP";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void Table_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            if (Nama_l.Text == "" || Nik.Text == "" || Email.Text == "" || Nohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                siswa mr = new siswa();
                siswa.Nama = Nama_l.Text;
                siswa.Nik = Nik.Text;
                siswa.Email = Email.Text;
                siswa.Nohp = Nohp.Text;

                mr.Update(siswa,id);
                Nama_l.Text = "";
                Nik.Text = "";
                Email.Text = "";
                Nohp.Text = "";

                Tampil();
            }
        }

        private void btn_Simpan_Click(object sender, EventArgs e)
        {
            if (Nama_l.Text == "" || Nik.Text == "" || Email.Text == "" || Nohp.Text == "" )
            {
                MessageBox.Show("Data tidak boleh kosong!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                siswa mr = new siswa();
                siswa.Nama = Nama_l.Text;
                siswa.Nik = Nik.Text;
                siswa.Email = Email.Text;
                siswa.Nohp = Nohp.Text;

                mr.Insert(siswa);
                Nama_l.Text = "";
                Nik.Text = "";
                Email.Text = "";
                Nohp.Text = "";

                Tampil();
            }
        }

        private void Cari_data_TextChanged(object sender, EventArgs e)
        {
            Table_data.DataSource = koneksi.ShowData("SELECT * FROM siswa WHERE nik LIKE '%' '"+ Cari_data.Text + "' '%' OR nama LIKE '%' '"+ Cari_data.Text + "' '%' ");
        }

        private void Nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void Table_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Table_data.Rows[e.RowIndex].Cells[0].Value.ToString();
            Nama_l.Text = Table_data.Rows[e.RowIndex].Cells[1].Value.ToString();
            Nik.Text = Table_data.Rows[e.RowIndex].Cells[2].Value.ToString();
            Email.Text = Table_data.Rows[e.RowIndex].Cells[3].Value.ToString();
            Nohp.Text = Table_data.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Yakin mau menghapus data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(pesan == DialogResult.Yes)
            {
                siswa mr = new siswa();
                mr.Delete(id);
                Nama_l.Text = "";
                Nik.Text = "";
                Email.Text = "";
                Nohp.Text = "";

                Tampil();
            }
        }
    }
}