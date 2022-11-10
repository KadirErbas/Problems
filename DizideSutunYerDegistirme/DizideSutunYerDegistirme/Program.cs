using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizideSutunYerDegistirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizim = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                {13, 14, 15, 16 },
                {17, 18, 19, 20 }
            };
            ikiBoyutluDiziYazdır(dizim);
            stunDegistir(dizim);
            ikiBoyutluDiziYazdır(dizim);

            Console.ReadLine();
        }
        static void stunDegistir(int[,] ikiBoyutluDizi)
        {
            int x;

            Console.WriteLine("Değiştirmek istediğiniz sütun numarası giriniz: ");
            int i = Convert.ToInt32(Console.ReadLine()) - 1;         //

            Console.WriteLine("Hangi sütun ile yer değiştirmesini istersiniz: ");
            int j = Convert.ToInt32(Console.ReadLine()) - 1;         //

            for (int k = 0; k < ikiBoyutluDizi.GetLength(0); k++)
            {
                x = ikiBoyutluDizi[k, i];
                ikiBoyutluDizi[k, i] = ikiBoyutluDizi[k, j];
                ikiBoyutluDizi[k, j] = x;
            }
        }
        static void ikiBoyutluDiziYazdır(int[,] ikiBoyutluDizi)
        {
            for (int k = 0; k < ikiBoyutluDizi.GetLength(0); k++)
            {
                for (int z = 0; z < ikiBoyutluDizi.GetLength(1); z++)
                {
                    Console.Write($"{ikiBoyutluDizi[k, z],4}");
                }
                Console.WriteLine();
            }

        }
    }
}
