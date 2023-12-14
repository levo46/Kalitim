using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class OkulPersoneli
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
    class Ogretmenler : OkulPersoneli
    {
        public string brans { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogretmenler ogretmenler = new Ogretmenler
            {
                Ad = "Nuri",
                Soyad = "Tıraş",
                brans = "Bilişim"
            };
            OkulPersoneli per = ogretmenler;
            Console.WriteLine(per.Ad);
            Console.WriteLine(per.Soyad);
        }
    }
}
