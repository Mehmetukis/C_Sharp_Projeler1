using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace İstediğin_yazıyı_istediğin_kadar_yazdırma
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yazılacak Cümleyi Giriniz: ");

            Console.WriteLine("");

            yazdı yazdır = new yazdı();

            Console.ReadLine();
        }
    }
    public class yazdı
    {
        public yazdı()
        {
            string metin = Console.ReadLine();

            Console.WriteLine("Miktarı Giriniz: ");

            int miktar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            for (int i = 1; i <= miktar; i++)
            {
                Console.WriteLine(i + "." + metin); 
            }
        }
    }
}