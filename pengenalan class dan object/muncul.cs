using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pengenalan_class_dan_object
{
    internal class Program
    {
        class program
        {
            static void Main(string[] args)
            {
                Mobil mobil1 = new Mobil();
                mobil1.Warna = "Putih";
                mobil1.JumlahPintu = 4;
                mobil1.Merek = "Mitsubishi";
                mobil1.Model = "Xpander";
                mobil1.TahunKeluaran = 2017;

                mobil1.InfoMobil();
                mobil1.Gas(170);
                mobil1.Klakson("Tut-tut-tut");
                mobil1.TampilanInfo();
            }
        }

    }
}