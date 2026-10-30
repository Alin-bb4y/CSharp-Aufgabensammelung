namespace Aufgabe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            double km = Convert.ToDouble(Console.ReadLine());
                
                if (km >42)
             {
                Console.WriteLine("Das schaffst du nicht!");
            }
            else
            {
                int n = (int)Math.Ceiling(km / 0.4);
                Console.WriteLine("Das sind " + n + " Runden")
            }    
        }
    }
}
