namespace DataStructure.ObjectReferences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Otomobil otomobil1 = new Otomobil("Audi");
            Console.WriteLine(otomobil1.Marka);

            Otomobil otomobil2;
            otomobil2 = otomobil1;

            otomobil1 = new Otomobil("Opel");

            Console.WriteLine(otomobil2.Marka);
            Console.WriteLine(otomobil1.Marka);

            otomobil2 = new Otomobil("Mercedes");

            Console.WriteLine(otomobil2.Marka);

            
            Console.ReadLine();
        }
    }
}
