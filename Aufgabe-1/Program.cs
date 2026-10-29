namespace Aufgabe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm berechnet die Summe von zwei Zahlen.");
            Console.WriteLine();

            Console.Write("Zahl 1: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zahl 2: ");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            int summe = zahl1 + zahl2;

            Console.WriteLine("Summe: " + summe);

            Console.ReadLine();
        }
    }
}
