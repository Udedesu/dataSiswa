using dataSiswa.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataSiswa.controller
{
    internal class siswa
    {
        //Memanggil class koneksi dan membuat objek baru
        Koneksi koneksi = new Koneksi();

        public bool Insert(siswa_m siswa)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO siswa (nama, nik, emali, nohp) VALUES ('" + siswa.Nama + "','" + siswa.Nik + "', '" + siswa.Email + "','" + siswa.Nohp + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Update(siswa_m siswa, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE siswa SET nama = '" + siswa.Nama + "', nik = '" + siswa.Nik + "', emali = '" + siswa.Email + "', nohp = '" + siswa.Nohp + "' WHERE id = '" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM siswa WHERE id = '" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

    }
}
