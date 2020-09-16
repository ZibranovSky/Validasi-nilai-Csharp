using System;

namespace ValidasiNilai
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Validasi nilai versi Csharp \n");
            Console.WriteLine("Masukkan nilai Matematika anda");
            int mtk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan nilai Matematika anda");
            int indo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan nilai Matematika anda");
            int inggris = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hasil : \n");

            if (mtk < 75 || indo < 75 || inggris < 75)
            {
                Console.WriteLine("nilai Matematika anda = " + mtk);
                Console.WriteLine("nilai Bahasa Indonesia anda = " + indo);
                Console.WriteLine("nilai Bahasa Inggris anda = " + inggris);
                Console.WriteLine("anda tidak lulus");
            }
            else
            {
                Console.WriteLine("nilai Matematika anda = " + mtk);
                Console.WriteLine("nilai Bahasa Indonesia anda = " + indo);
                Console.WriteLine("nilai Bahasa Inggris anda = " + inggris);
                Console.WriteLine("anda lulus");
            }
        }
    }
}
