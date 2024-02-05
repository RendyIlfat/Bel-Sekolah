using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using Component;
using Database;
using System.Threading;
namespace Project_Bel_Sekolah
{
    class Program
    {
        public static AccessDatabaseHelper DB = new AccessDatabaseHelper("./Database.accdb");

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Kotak Kepala = new Kotak();
            Kepala.X = 0;
            Kepala.Y = 0;
            Kepala.Width = 119;
            Kepala.Height = 4;
            Kepala.SetForeColor(ConsoleColor.DarkRed);
            Kepala.Tampil();

            new Tulisan("7??777???7~:-----------                                                                      -----------:~7??777??77").SetXY(2, 1).SetLength(116).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7??777?:----------                                                                                ----------:7??777?").SetXY(2, 2).SetLength(116).SetForeColor(ConsoleColor.Gray).TampilTengah();                      
            new Tulisan("7??777???7~:-----------                                                                      -----------:~7??777??77").SetXY(2, 3).SetLength(116).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();

            Kotak kiri = new Kotak();
            kiri.SetXY(0, 5);
            kiri.SetWidthAndHeight(30, 19);
            kiri.SetForeColor(ConsoleColor.DarkRed);
            kiri.Tampil();

            Kotak kanan = new Kotak();
            kanan.SetXY(32, 5);
            kanan.SetWidthAndHeight(87, 19);
            kanan.SetForeColor(ConsoleColor.DarkRed);
            kanan.Tampil();

            Kotak bawah = new Kotak();
            bawah.SetXY(0, 25);
            bawah.SetWidthAndHeight(119, 4);
            bawah.SetForeColor(ConsoleColor.DarkRed);
            bawah.Tampil();

            new Tulisan("7??777???7~:-----------                                                                      -----------:~7??777??77").SetXY(2, 26).SetLength(116).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7??777?:----------                                                                                ----------:7??777?").SetXY(2, 27).SetLength(116).SetForeColor(ConsoleColor.Gray).TampilTengah();
            new Tulisan("7??777???7~:-----------                                                                      -----------:~7??777??77").SetXY(2, 28).SetLength(116).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();

            Tulisan NamaApp1 = new Tulisan();
            NamaApp1.SetText("APLIKASI BEL SEKOLAH").SetXY(12, 1).SetLength(97);
            NamaApp1.ForeColor = ConsoleColor.Green;
            NamaApp1.TampilTengah();

            Tulisan NamaApp2 = new Tulisan();
            NamaApp2.SetText("WEARNES EDUCATION CENTER MADIUN").SetXY(12, 2).SetLength(97);
            NamaApp2.ForeColor = ConsoleColor.DarkBlue;
            NamaApp2.TampilTengah();

            Tulisan NamaApp3 = new Tulisan();
            NamaApp3.SetText("JL. THAMRIN 35A KOTA MADIUN").SetXY(12, 3).SetLength(97);
            NamaApp3.ForeColor = ConsoleColor.DarkCyan;
            NamaApp3.TampilTengah();

            Tulisan Nama1 = new Tulisan();
            Nama1.SetText("RENDI ILFAT IBRAHIM NASTIYAN").SetXY(12, 26).SetLength(97);
            Nama1.ForeColor = ConsoleColor.DarkCyan;
            Nama1.TampilTengah();

            Tulisan Nama2 = new Tulisan();
            Nama2.SetText("INFORMATIKA 2").SetXY(12, 28).SetLength(97);
            Nama2.ForeColor = ConsoleColor.DarkBlue;
            Nama2.TampilTengah();


            Menu menu = new Menu("    JALANKAN     ", "   LIHAT DATA    ", "   TAMBAH DATA   ", "   EDIT DATA     ", "   HAPUS DATA    ", "     KELUAR      ");
            menu.SetXY(8, 12);
            menu.ForeColor = ConsoleColor.Yellow;
            menu.SelectedBackColor = ConsoleColor.DarkYellow;
            menu.SelectedForeColor = ConsoleColor.Black;
            menu.Tampil();

            Logo();

            bool IsProgamJalan = true;

            while (IsProgamJalan)
            {
                ConsoleKeyInfo Tombol = Console.ReadKey(true);
               
                if (Tombol.Key == ConsoleKey.DownArrow)
                {

                    menu.Next();
                    menu.Tampil();

                }
                else if (Tombol.Key == ConsoleKey.UpArrow)
                {
                    menu.Prev();
                    menu.Tampil();
                }
                else if (Tombol.Key == ConsoleKey.Enter)
                {

                    int MenuTerpilih = menu.SelectedIndex;

                    if (MenuTerpilih == 0)
                    {
                        Jalankan();
                    }
                    else if (MenuTerpilih == 1)
                    {
                        LihatData();
                    }
                    else if (MenuTerpilih == 2)
                    {
                        TambahData();
                    }
                    else if (MenuTerpilih == 3)
                    {
                        EditData();
                    }
                    else if (MenuTerpilih == 4)
                    {
                        HapusData();
                    }
                    else if (MenuTerpilih == 5)
                    {
                        IsProgamJalan = false;
                    }
                }
            }         
        }

        static void Jalankan()
        {
            new Clear(33, 6, 84, 17).Tampil();

            Tulisan Judul = new Tulisan();
            Judul.SetXY(35, 9).SetText("...:--BEL SEKOLAH SEDANG BERJALAN--:...").SetLength(79);
            Judul.SetForeColor(ConsoleColor.DarkGreen);
            Judul.TampilTengah();

            new Tulisan("      |||||||||||||||                                        |||||||||||||||      ").SetXY(36, 6).SetLength(79).SetForeColor(ConsoleColor.Blue).TampilTengah();
            new Tulisan("------|--------------                                        --------------|------").SetXY(36, 7).SetLength(79).SetForeColor(ConsoleColor.Green).TampilTengah();
            new Tulisan("|||||||                                                                    |||||||").SetXY(36, 8).SetLength(79).SetForeColor(ConsoleColor.Magenta).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 10).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 11).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 12).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 13).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 14).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 15).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 16).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 17).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 18).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 19).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            //new Tulisan("7                                                                                7").SetXY(36, 20).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("|||||||                                                                    |||||||").SetXY(36, 21).SetLength(79).SetForeColor(ConsoleColor.Magenta).TampilTengah();
            new Tulisan("------|--------------                                        --------------|------").SetXY(36, 22).SetLength(79).SetForeColor(ConsoleColor.Green).TampilTengah();
            new Tulisan("      |||||||||||||||                                        |||||||||||||||      ").SetXY(36, 23).SetLength(79).SetForeColor(ConsoleColor.Blue).TampilTengah();


            Tulisan HariSekarang = new Tulisan().SetXY(62, 14);
            Tulisan JamSekarang = new Tulisan().SetXY(62, 15);

            string QSelect = "SELECT * FROM tb_jadwal WHERE hari =@hari AND jam=@jam;";

            DB.Connect();

            bool Play = true;

            while (Play)
            {

                DateTime Sekarang = DateTime.Now;

                HariSekarang.SetText("HARI SEKARANG  : " + Sekarang.ToString("dddd"));
                HariSekarang.SetForeColor(ConsoleColor.Yellow);
                HariSekarang.Tampil();

                JamSekarang.SetText("JAM  SEKARANG  : " + Sekarang.ToString("HH:mm:ss"));
                JamSekarang.SetForeColor(ConsoleColor.Yellow);
                JamSekarang.Tampil();

                DataTable DT = DB.RunQuery(QSelect,
                    new OleDbParameter("@hari", Sekarang.ToString("dddd")),
                    new OleDbParameter("@jam", Sekarang.ToString("HH:mm")));

                if(DT.Rows.Count > 0)
                {

                    Audio AAA = new Audio();
                    AAA.File = "./Suara/" + DT.Rows[0]["sound"];
                    AAA.Play();

                    new Tulisan().SetXY(35, 17).SetText("BEL TELAH BERBUNYI").SetBackColor(ConsoleColor.Red).SetLength(79).TampilTengah();
                    new Tulisan().SetXY(35, 18).SetText(DT.Rows[0]["ket"].ToString()).SetBackColor(ConsoleColor.Red).SetLength(79).TampilTengah();

                    Play = false;

                }

                Thread.Sleep(1000);

            }
        }

        static void LihatData()
        {
            new Clear(33, 6, 84, 17).Tampil();

            Tulisan Judul = new Tulisan();
            Judul.SetXY(35, 9).SetText("...:--LIHAT DATA JADWAL--:...").SetLength(79);
            Judul.SetForeColor(ConsoleColor.DarkGreen);
            Judul.TampilTengah();

            new Tulisan("      |||||||||||||||                                        |||||||||||||||      ").SetXY(36, 6).SetLength(79).SetForeColor(ConsoleColor.Blue).TampilTengah();
            new Tulisan("------|--------------                                        --------------|------").SetXY(36, 7).SetLength(79).SetForeColor(ConsoleColor.Green).TampilTengah();
            new Tulisan("|||||||                                                                    |||||||").SetXY(36, 8).SetLength(79).SetForeColor(ConsoleColor.Magenta).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 10).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 11).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 12).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 13).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 14).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 15).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 16).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 17).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 18).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 19).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            //new Tulisan("7                                                                                7").SetXY(36, 20).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("|||||||                                                                    |||||||").SetXY(36, 21).SetLength(79).SetForeColor(ConsoleColor.Magenta).TampilTengah();
            new Tulisan("------|--------------                                        --------------|------").SetXY(36, 22).SetLength(79).SetForeColor(ConsoleColor.Green).TampilTengah();
            new Tulisan("      |||||||||||||||                                        |||||||||||||||      ").SetXY(36, 23).SetLength(79).SetForeColor(ConsoleColor.Blue).TampilTengah();

            DB.Connect();
            DataTable DT = DB.RunQuery("SELECT * FROM tb_jadwal;");
            DB.Disconnect();

            new Tulisan("┌──────┬─────────────────┬───────────┬───────────────────────────┐").SetXY(43, 11).SetForeColor(ConsoleColor.Yellow).Tampil();
            new Tulisan("│  NO  │      HARI       │    JAM    │        KETERANGAN         │").SetXY(43, 12).SetForeColor(ConsoleColor.Yellow).Tampil();
            new Tulisan("├──────┼─────────────────┼───────────┼───────────────────────────┤").SetXY(43, 13).SetForeColor(ConsoleColor.Yellow).Tampil();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                string ID = DT.Rows[i]["id"].ToString();
                string Hari = DT.Rows[i]["hari"].ToString();
                string Jam = DT.Rows[i]["jam"].ToString();
                string Keterangan = DT.Rows[i]["ket"].ToString();

                String isi = String.Format("|{0, -6}|{1, -17}|{2, -11}|{3, -27}|", ID, Hari, Jam, Keterangan);
                new Tulisan(isi).SetXY(43, 14 + i).SetForeColor(ConsoleColor.Yellow).Tampil();
            }

            new Tulisan("└──────┴─────────────────┴───────────┴───────────────────────────┘").SetXY(43, 14 + DT.Rows.Count).SetForeColor(ConsoleColor.Yellow).Tampil();

        }

        static void TambahData()
        {
            new Clear(33, 6, 84, 17).Tampil();

            Tulisan Judul = new Tulisan();
            Judul.SetXY(35, 9).SetText("...:--TAMBAH DATA JADWAL--:...").SetLength(79);
            Judul.SetForeColor(ConsoleColor.DarkGreen);
            Judul.TampilTengah();

            new Tulisan("      |||||||||||||||                                        |||||||||||||||      ").SetXY(36, 6).SetLength(79).SetForeColor(ConsoleColor.Blue).TampilTengah();
            new Tulisan("------|--------------                                        --------------|------").SetXY(36, 7).SetLength(79).SetForeColor(ConsoleColor.Green).TampilTengah();
            new Tulisan("|||||||                                                                    |||||||").SetXY(36, 8).SetLength(79).SetForeColor(ConsoleColor.Magenta).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 10).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 11).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 12).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 13).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 14).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 15).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 16).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 17).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 18).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 19).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            //new Tulisan("7                                                                                7").SetXY(36, 20).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("|||||||                                                                    |||||||").SetXY(36, 21).SetLength(79).SetForeColor(ConsoleColor.Magenta).TampilTengah();
            new Tulisan("------|--------------                                        --------------|------").SetXY(36, 22).SetLength(79).SetForeColor(ConsoleColor.Green).TampilTengah();
            new Tulisan("      |||||||||||||||                                        |||||||||||||||      ").SetXY(36, 23).SetLength(79).SetForeColor(ConsoleColor.Blue).TampilTengah();

            Inputan HariInput = new Inputan();
            HariInput.Text = "Masukkan Hari       :";
            HariInput.SetXY(54, 13);
            HariInput.SetForeColor(ConsoleColor.Yellow);
           
            Inputan JamInput = new Inputan();
            JamInput.Text = "Masukkan Jam        :";
            JamInput.SetXY(54, 14);
            JamInput.SetForeColor(ConsoleColor.Yellow);
           
            Inputan KetInput = new Inputan();
            KetInput.Text = "Masukkan Keterangan :";
            KetInput.SetXY(54, 15);
            KetInput.SetForeColor(ConsoleColor.Yellow);        

            //Inputan SoundInput = new Inputan();
            //SoundInput.Text = "Masukkan Audio :";
            //SoundInput.SetXY(33, 12);

            Pilihan SoundInput = new Pilihan();
            SoundInput.SetPilihans(
                "Pelajaran ke 1.wav",
                "Pelajaran ke 2.wav",
                "Pelajaran ke 3.wav",
                "Pelajaran ke 4.wav",
                "Pelajaran ke 5.wav",
                "Pelajaran ke 6.wav",
                "Pelajaran ke 7.wav",
                "Pelajaran ke 8.wav",
                "Pelajaran ke 9.wav");

            SoundInput.Text = "Masukkan Audio      :";
            SoundInput.SetXY(54, 16);
            SoundInput.SetForeColor(ConsoleColor.Yellow);         

            string Hari = HariInput.Read();
            string Jam = JamInput.Read();
            string Ket = KetInput.Read();
            string Sound = SoundInput.Read();


            DB.Connect();
            DB.RunNonQuery("INSERT INTO tb_jadwal (hari, jam, ket, sound ) VALUES ( @hari, @jam, @ket, @sound );",
                new OleDbParameter("@hari", Hari),
                new OleDbParameter("@jam", Jam),
                new OleDbParameter("@ket", Ket),
                new OleDbParameter("@sound", Sound));
            DB.Disconnect();

            new Tulisan().SetText("Data Berhasil Di Simpan!!!").SetBackColor(ConsoleColor.Red).SetXY(35, 18).SetLength(79).TampilTengah();

        }

        static void EditData()
        {
            new Clear(33, 6, 84, 17).Tampil();

            Tulisan Judul = new Tulisan();
            Judul.SetXY(35, 9).SetText("...:--EDIT DATA JADWAL--:...").SetLength(79);
            Judul.SetForeColor(ConsoleColor.DarkGreen);
            Judul.TampilTengah();

            new Tulisan("      |||||||||||||||                                        |||||||||||||||      ").SetXY(36, 6).SetLength(79).SetForeColor(ConsoleColor.Blue).TampilTengah();
            new Tulisan("------|--------------                                        --------------|------").SetXY(36, 7).SetLength(79).SetForeColor(ConsoleColor.Green).TampilTengah();
            new Tulisan("|||||||                                                                    |||||||").SetXY(36, 8).SetLength(79).SetForeColor(ConsoleColor.Magenta).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 10).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 11).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 12).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 13).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 14).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 15).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 16).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 17).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 18).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 19).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            //new Tulisan("7                                                                                7").SetXY(36, 20).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("|||||||                                                                    |||||||").SetXY(36, 21).SetLength(79).SetForeColor(ConsoleColor.Magenta).TampilTengah();
            new Tulisan("------|--------------                                        --------------|------").SetXY(36, 22).SetLength(79).SetForeColor(ConsoleColor.Green).TampilTengah();
            new Tulisan("      |||||||||||||||                                        |||||||||||||||      ").SetXY(36, 23).SetLength(79).SetForeColor(ConsoleColor.Blue).TampilTengah();

            Inputan IDInputDirubah = new Inputan();
            IDInputDirubah.Text = "Masukkan ID Jadwal Yang Ingin Di Rubah :";
            IDInputDirubah.SetXY(54, 12);
            IDInputDirubah.SetForeColor(ConsoleColor.Yellow);

            Inputan HariInput = new Inputan();
            HariInput.Text = "Masukkan Hari       :";
            HariInput.SetXY(54, 14);
            HariInput.SetForeColor(ConsoleColor.Yellow);

            Inputan JamInput = new Inputan();
            JamInput.Text = "Masukkan Jam        :";
            JamInput.SetXY(54, 15);
            JamInput.SetForeColor(ConsoleColor.Yellow);

            Inputan KetInput = new Inputan();
            KetInput.Text = "Masukkan Keterangan :";
            KetInput.SetXY(54, 16);
            KetInput.SetForeColor(ConsoleColor.Yellow);

            //Inputan SoundInput = new Inputan();
            //SoundInput.Text = "Masukan Audio :";
            //SoundInput.SetXY(33, 12);

            Pilihan SoundInput = new Pilihan();
            SoundInput.SetPilihans(
                "Pelajaran ke 1.wav",
                "Pelajaran ke 2.wav",
                "Pelajaran ke 3.wav",
                "Pelajaran ke 4.wav",
                "Pelajaran ke 5.wav",
                "Pelajaran ke 6.wav",
                "Pelajaran ke 7.wav",
                "Pelajaran ke 8.wav",
                "Pelajaran ke 9.wav");

            SoundInput.Text = "Masukkan Audio      :";
            SoundInput.SetXY(54, 17);
            SoundInput.SetForeColor(ConsoleColor.Yellow);

            string IDRubah = IDInputDirubah.Read();
            string Hari = HariInput.Read();
            string Jam = JamInput.Read();
            string Ket = KetInput.Read();
            string Sound = SoundInput.Read();

            DB.Connect();
            DB.RunNonQuery("UPDATE tb_jadwal SET hari=@hari, jam=@jam, ket=@ket, sound=@sound WHERE id=@id;",
                new OleDbParameter("@hari", Hari),
                new OleDbParameter("@jam", Jam),
                new OleDbParameter("@ket", Ket),
                new OleDbParameter("@sound", Sound),
                new OleDbParameter("@id", IDRubah));

            DB.Disconnect();

            new Tulisan().SetXY(35, 20).SetText("Data Berhasil Di UPDATE!!!").SetBackColor(ConsoleColor.Red).SetLength(79).TampilTengah();

        }

        static void HapusData()
        {

            new Clear(33, 6, 84, 17).Tampil();

            Tulisan Judul = new Tulisan();
            Judul.SetXY(35, 9).SetText("...:--HAPUS DATA JADWAL--:...").SetLength(79);
            Judul.SetForeColor(ConsoleColor.DarkGreen);
            Judul.TampilTengah();

            new Tulisan("      |||||||||||||||                                        |||||||||||||||      ").SetXY(36, 6).SetLength(79).SetForeColor(ConsoleColor.Blue).TampilTengah();
            new Tulisan("------|--------------                                        --------------|------").SetXY(36, 7).SetLength(79).SetForeColor(ConsoleColor.Green).TampilTengah();
            new Tulisan("|||||||                                                                    |||||||").SetXY(36, 8).SetLength(79).SetForeColor(ConsoleColor.Magenta).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 10).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 11).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 12).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 13).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 14).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 15).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 16).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 17).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 18).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                                                                7").SetXY(36, 19).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            //new Tulisan("7                                                                                7").SetXY(36, 20).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("|||||||                                                                    |||||||").SetXY(36, 21).SetLength(79).SetForeColor(ConsoleColor.Magenta).TampilTengah();
            new Tulisan("------|--------------                                        --------------|------").SetXY(36, 22).SetLength(79).SetForeColor(ConsoleColor.Green).TampilTengah();
            new Tulisan("      |||||||||||||||                                        |||||||||||||||      ").SetXY(36, 23).SetLength(79).SetForeColor(ConsoleColor.Blue).TampilTengah();

            Inputan IDInput = new Inputan();
            IDInput.Text = "Masukkan ID Yang Akan Di Hapus  :";
            IDInput.SetXY(53, 14);
            IDInput.SetForeColor(ConsoleColor.Yellow);
            string ID = IDInput.Read();

            DB.Connect();
            DB.RunNonQuery("DELETE FROM tb_jadwal WHERE id=@id;",
                new OleDbParameter("@id", ID));
            DB.Disconnect();

            new Tulisan().SetXY(35, 18).SetText("Data Berhasil Di Hapus!!!").SetBackColor(ConsoleColor.Red).SetLength(79).TampilTengah();
        }

        static void Logo()
        {
            new Tulisan("      |||||||||||||||_______________          _______________|||||||||||||||      ").SetXY(36, 6).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("------|--------------------                            --------------------|------").SetXY(36, 7).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("|||||||------                           ##                           ------|||||||").SetXY(36, 8).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7|||------                            #5?J5#                            ------|||7").SetXY(36, 9).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                                     &557?#                                     7").SetXY(36, 10).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                        &#&&&&&BBPPBJJP?^YGGBB##B#####                          7").SetXY(36, 11).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                     #PJ7??7YP7~~!~^:!Y!..^~7?JP!~???!?5G                       7").SetXY(36, 12).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                   #57^YGB#P57:?#&&&P7Y!.5BBB##55^5@&#P?JP                      7").SetXY(36, 13).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                   B? 7....&J?^?....#.7^ G....GJ7:B....JY?&                     7").SetXY(36, 14).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                   #Y^^G....BY7^Y...#?7^7&..&Y!!^B....#5YG                      7").SetXY(36, 15).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                    &#B???P5PPY75Y5Y557!YY?J~:^^!Y7: .Y&#                       7").SetXY(36, 16).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                       #?^PP7GG?Y#GJ5P!755^7P!:YJ:YY~G                          7").SetXY(36, 17).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                         #!7^~?5JJ57?7J7^^7^!7~!^:^?#                           7").SetXY(36, 18).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7                          7~^::7!~~~!~~^::~~77^^:^~P                            7").SetXY(36, 19).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("7|||------                  #GPYJJJYJYYYYY5PPG#BPPGG#                   ------|||7").SetXY(36, 20).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("|||||||------                                                        ------|||||||").SetXY(36, 21).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("------|--------------------                            --------------------|------").SetXY(36, 22).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan("      |||||||||||||||_______________          _______________|||||||||||||||      ").SetXY(36, 23).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();


            new Tulisan("7???77???7~:.  .:~7???77??77").SetXY(2, 6).SetLength(79).SetForeColor(ConsoleColor.Blue).Tampil();
            new Tulisan("7?!??!?7:..      ..:?!?7?!?7").SetXY(2, 7).SetLength(79).SetForeColor(ConsoleColor.Green).Tampil();
            new Tulisan("7^7^7...            ...7^7^7").SetXY(2, 8).SetLength(79).SetForeColor(ConsoleColor.Magenta).Tampil();
            new Tulisan("77....                ....77").SetXY(2, 9).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).Tampil();
            new Tulisan("77....                ....77").SetXY(2, 10).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).Tampil();
            new Tulisan("77....                ....77").SetXY(2, 11).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).Tampil();
           //new Tulisan("                           ").SetXY(2, 12).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).Tampil();
           //new Tulisan("                           ").SetXY(2, 13).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).Tampil();
           //new Tulisan("                           ").SetXY(2, 14).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).Tampil();
           //new Tulisan("                           ").SetXY(2, 15).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).Tampil();
           //new Tulisan("                           ").SetXY(2, 16).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).Tampil();
           //new Tulisan("                           ").SetXY(2, 17).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).Tampil();
            new Tulisan("77....                ....77").SetXY(2, 18).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).Tampil();
            new Tulisan("77....                ....77").SetXY(2, 19).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).Tampil();
            new Tulisan("77....                ....77").SetXY(2, 20).SetLength(79).SetForeColor(ConsoleColor.DarkYellow).Tampil();
            new Tulisan("7^7^7...            ...7^7^7").SetXY(2, 21).SetLength(79).SetForeColor(ConsoleColor.Magenta).Tampil();
            new Tulisan("7?!??!?7:..      ..:7?!??!?7").SetXY(2, 22).SetLength(79).SetForeColor(ConsoleColor.Green).Tampil();
            new Tulisan("7???77???7~:.  .:~7???77??77").SetXY(2, 23).SetLength(79).SetForeColor(ConsoleColor.Blue).Tampil();



        }




    }
}
