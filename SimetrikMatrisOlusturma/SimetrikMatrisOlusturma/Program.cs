using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimetrikMatrisOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            simetrikMatrisOlustur(5);
            Console.ReadKey();
        }
        static void simetrikMatrisOlustur(int kareselMatrisBoyutu)
        {
            int[,] dizi = new int[kareselMatrisBoyutu,kareselMatrisBoyutu]; int k = 1;
            for (int i = 0; i < dizi.GetLength(0); i++)

                for (int j = i; j < dizi.GetLength(1); j++)
                {
                    dizi[i, j] = k;
                    dizi[j, i] = k;
                    k++;
                }
            k = 1;


            foreach (int x in dizi)
            {
                if (k % dizi.GetLength(0) == 0)
                {
                    Console.WriteLine($"{x,5}");
                }
                else
                {
                    Console.Write($"{x,5}");
                }
                k++;
            }
        }
    }
}
