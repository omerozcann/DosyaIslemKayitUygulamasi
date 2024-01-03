using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaIslemOrnek10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String veri, secim="";
            do
            {
                Console.Clear();
                Console.WriteLine("Kayıt(K),Listele(L),Tüm Verileri Sil(S),Çıkış(E)");
                secim= Console.ReadLine();
                if(secim=="K")
                {
                    Console.WriteLine("Kaydedilecek veri:");
                    veri= Console.ReadLine();
                    File.AppendAllText("kayitlar.txt", veri);
                    Console.WriteLine("Veri kaydedildi");
                }else if(secim=="L")
                {
                    if (File.Exists("kayitlar.txt") == true)
                    {
                        veri = File.ReadAllText("kayitlar.txt");
                        Console.WriteLine(veri);
                    }
                    else
                    {
                        Console.WriteLine("Herhangi bir kayıt yok");
                    }
                }else if(secim=="S")
                {
                    File.Delete("kayitlar.txt");
                }           
                else 
                {
                    if (secim != "E")
                    {
                        Console.WriteLine("Yanlış seçim!");
                    }
                }

                if (secim != "E")
                {
                    Console.WriteLine("Çıkmak İstiyor musunuz (E/H)");
                    secim = Console.ReadLine();
                }

            } while (secim != "E");
        }
    }
}
