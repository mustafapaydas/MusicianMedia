using System;
using System.Threading;
using System.Threading.Tasks;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("İşlemler başlıyor");

                Task.Run(()=>BirinciIslem());

                IkinciIslem();

                Console.WriteLine("İşlemler tamamlandı.");
            }

            public static void BirinciIslem()
            {
                Console.WriteLine("Birinci işlem başladı");

                //Thread.Sleep(2000);
                Console.WriteLine("Birinci işlemde 2 sn bekleme uygulandı.");

                Console.WriteLine("Birinci işlem bitti");
            }

            public static void IkinciIslem()
            {
                Console.WriteLine("Ikinci işlem başladı");

                Console.WriteLine("Ikinci işlem bitti");
            }
        }
    }

