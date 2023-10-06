namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "c sharp";
            string kurs2 = "java";
            string kurs3 = "python";
            string kurs4 = "Html";

            string[] kurslar = new string[] { "c sharp", "java", "python", "Html" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {

                Console.WriteLine(kurs);

            }
            Console.WriteLine("sayfa sonu.");

        }
    }
}