namespace ResponsiPemrograman4389
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama     : Khoirudin Yoga Pratama");
            Console.WriteLine("NIM      : 21.11.4389");
            Console.WriteLine("Kelas    : IF 08");

            Console.WriteLine("\n");


            Kariawan kariawan1 = new Kariawan(1911, "Khoirudin", 3000000);
            Kariawan kariawan2 = new Kariawan(2742, "Yoga", 2000000);
            Kariawan kariawan3 = new Kariawan(1519, "Pratama", -100000);
            
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", kariawan1.NIK, kariawan1.Nama, kariawan1.GajiperBulanan);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", kariawan2.NIK, kariawan2.Nama, kariawan2.GajiperBulanan);
            Console.WriteLine(" 3. | {0} {1} \t\t | {2}\t\t |", kariawan3.NIK, kariawan3.Nama, kariawan3.GajiperBulanan);

            Console.WriteLine("\nNaik Gaji \n");

            Console.WriteLine(" NO | NIK  NAMA\t\t | Gaji Perbulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", kariawan1.NIK, kariawan1.Nama, kariawan1.Gajii);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", kariawan2.NIK, kariawan2.Nama, kariawan2.Gajii);
            Console.WriteLine(" 3. | {0} {1} \t\t | {2}\t\t |", kariawan3.NIK, kariawan3.Nama, kariawan3.GajiperBulanan);

            Console.ReadKey();
        }
    }
}