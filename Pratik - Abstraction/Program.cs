using System;
using AbstractionExample.Base;
using AbstractionExample.Calisanlar;

namespace AbstractionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yazılım Geliştirici nesnesi
            YazilimGelistirici yazilimci = new YazilimGelistirici
            {
                Ad = "Serdar",
                Soyad = "Ortaç",
                Departman = "Yazılım Geliştirme"
            };
            yazilimci.CalisanBilgileri();
            yazilimci.Gorev();

            Console.WriteLine();

            // Proje Yöneticisi nesnesi
            ProjeYoneticisi yonetici = new ProjeYoneticisi
            {
                Ad = "Hasan",
                Soyad = "Çıldırmış",
                Departman = "Proje Yönetimi"
            };
            yonetici.CalisanBilgileri();
            yonetici.Gorev();

            Console.WriteLine();

            // Satış Temsilcisi nesnesi
            SatisTemsilcisi satisci = new SatisTemsilcisi
            {
                Ad = "Zeynep",
                Soyad = "Arslan",
                Departman = "Satış"
            };
            satisci.CalisanBilgileri();
            satisci.Gorev();
        }
    }
}
