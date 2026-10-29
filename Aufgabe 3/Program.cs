namespace Aufgabe_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib eine Zahl ein:");
            int i = Convert.ToInt32(Console.ReadLine());

            while (i <= 10) 
            Console.WriteLine(i++);
        }
    }
}
