using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();
        Mahasiswa Maha = new Mahasiswa();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
                Console.Clear();
                Console.Write("Pilih Menu Aplikasi");
                Console.Write("\n");
                Console.Write("\n1. Tambah Mahasiswa");
                Console.Write("\n2. Tampilkan Mahasiswa");
                Console.Write("\n3. Keluar");
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            Mahasiswa Maha = new Mahasiswa();

            Console.Write("Tambah Mahasiswa");
            Console.Write("\n\nNIM     : ");
            Maha.nim = double.Parse(Console.ReadLine());

            Console.Write("Nama    : ");
            Maha.Nama = Console.ReadLine();

            Console.Write("Jenis Kelamin [L/P] : ");
            Maha.jk = Console.ReadLine();
            if (Maha.jk == "L")
            {
                Maha.jk = "Laki-Laki";
            }
            else if (Maha.jk == "P")
            {
                Maha.jk = "Perempuan";
            }

            Console.Write("IPK     : ");
            Maha.ipk = double.Parse (Console.ReadLine());
            daftarMahasiswa.Add(Maha);
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
        }


        static void TampilMahasiswa()
        {

            Console.Clear();
            Console.WriteLine("Data Mahasiswa\n");
            int no = 1;
            foreach (Mahasiswa Maha in daftarMahasiswa)
            {

                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", no, Maha.nim, Maha.Nama, Maha.jk, Maha.ipk);
                no++;
            }
            Console.WriteLine();
            Console.WriteLine("Tekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
