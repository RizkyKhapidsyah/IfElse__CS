using System;

namespace IfElse__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nilai;
            string Hasil = null, Input;

            Console.Write("Masukkan Nilai (1-100) : ");
            Nilai = Convert.ToInt32(Input = Console.ReadLine());


            if (Nilai >= 90) 
            {
                Hasil = "Suhu";
            }
            else if (Nilai >= 70)
            {
                Hasil = "Master";
            }
            else if (Nilai >= 50)
            {
                Hasil = "Jago";
            }
            else if (Nilai >= 30)
            {
                Hasil = "Standard";
            }
            else if (Nilai >= 10)
            {
                Hasil = "Newbie";
            }
            else if (Nilai >= 4)
            {
                Hasil = "Pemula";
            }
            else if (Nilai >= 0)
            {
                Hasil = "Parah Sekali";
            }
            else if (Nilai <= 0) 
            {
                Hasil = "Wassalam";
            }
            
            Console.WriteLine("Anda {0}", Hasil);
            Console.ReadLine();
        }
    }
}
