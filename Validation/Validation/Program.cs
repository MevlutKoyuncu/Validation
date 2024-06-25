using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"///////// SİSTEME HOŞGELDİNİZ \\\\\\\\\\");


            int denemeHakki = 2;

            while (denemeHakki >= 0)
            {

                Console.Write("Kullanıcı adı giriniz =  ");
                string kullaniciAdi = Console.ReadLine();

                if (kullaniciAdi == "admin")
                {
                    Console.Write("Şifrenizi giriniz = ");
                    string sifre = Console.ReadLine();
                    if (sifre == "1234")
                    {
                        Console.WriteLine("Sisteme Hoşgeldiniz. " + kullaniciAdi);
                        denemeHakki = denemeHakki - 2;
                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı adınızı ve Şifrenizi kontrol edip tekrar deneyiniz. Kalan deneme hakkınız " + denemeHakki);
                        if (denemeHakki == 0)
                        {
                            Console.WriteLine("Deneme hakkınız kalmamıştır. Sistem bloke edilecektir.");
                        }
                    }
                }
                else
                {

                    Console.WriteLine("Kullanıcı adınızı ve şifrenizi kontrol edip tekrar deneyiniz. Kalan deneme hakkınız " + denemeHakki);
                    if (denemeHakki == 0)
                    {
                        Console.WriteLine("Deneme hakkınız kalmamıştır. Sistem bloke edilecektir.");
                    }
                }

                denemeHakki--;

            }

        }
    }
}
