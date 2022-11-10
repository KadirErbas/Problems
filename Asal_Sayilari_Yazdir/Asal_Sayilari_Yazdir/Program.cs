using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asal_Sayilari_Yazdir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            asalSayiYazdir();
            Console.ReadLine(); 
        }
        static void asalSayiYazdir()
        {
            
            int k, t, toplam, n1, n2;

            do
            {
                Console.Write("Baslangic gir: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bitis gir: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                if (n1 < 0)
                {
                    Console.WriteLine("Baslangıc degeri pozitif olmalıdır.");
                }
                if (n1 > n2)
                {
                    Console.WriteLine("Lutfen Gecerli Aralik Giriniz.");
                }
            } while (n1<0 || n1 > n2);

            Console.WriteLine($"{n1} ve {n2} aralıgındaki asal sayilar:");
                
            for (k = n1; k <= n2; k++)
                {
                    
                    toplam = 0;
                    for (t = 1; t <= k; t++)
                    {
                        if (k % t == 0)
                            toplam = toplam + t;
                    }
                    if (toplam == (k + 1)) 
                        Console.WriteLine(k);
                }
                       
        }
    
    
    }
}
