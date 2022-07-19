using System;

namespace Odev1_Kodlama_io
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs JavaScKurs = new Kurs();
            JavaScKurs.KursAdi = " JavaSCript Yazılımcı Kampı";
            JavaScKurs.KursEgitmen = "Engin DEMİROĞ";
            Kurs CAngularKurs = new Kurs();
            CAngularKurs.KursAdi = " C# Yazılım Geliştirici Kampı";
            CAngularKurs.KursEgitmen = "Engin Demiroğ";
            Kurs JavaKurs= new Kurs();
            JavaKurs.KursAdi = " Java & React Yazılım Geliştirici Kampı";
            JavaKurs.KursEgitmen = "Engin Demiroğ";

            Kurs[] kurslarim = new Kurs[] {JavaScKurs, CAngularKurs,JavaKurs};


            foreach (Kurs kursum in kurslarim)
            {
                Console.WriteLine(kursum.KursAdi);
                Console.WriteLine(kursum.KursEgitmen);

            }





        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmen { get; set; }

    }
}

