namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berechnung von anzahl sekunden in ein Monat anhand der Tagesanzahl im Monat.");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Gib die anzahl Tagen an vom gewünschten Monat.");
            int tage = int.Parse(Console.ReadLine());
            int sekunden = tage * 24 * 60 * 60;
            Console.WriteLine($"Ein Monat mit {tage} hat {sekunden} sekunden.");
        }
    }
}
