using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataSiswa.model
{
    internal class siswa_m
    {
        string nama, nik, email, nohp;

        public siswa_m() { }

        public siswa_m(string nama, string nik, string email, string nohp)
        {
            this.Nama = nama;
            this.Nik = nik;
            this.Email = email;
            this.Nohp = nohp;
        }

        public string Nama { get => nama; set => nama = value; }
        public string Nik { get => nik; set => nik = value; }
        public string Email { get => email; set => email = value; }
        public string Nohp { get => nohp; set => nohp = value; }
    }
}
