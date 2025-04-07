using Humanizer;
using System.Drawing;
using System.Threading.Channels;
using Console = Colorful.Console;
namespace LAB10_PARTIE2
{
    internal class Program
    {
        static void TestHumain()
        {
            Console.WriteLine("LOL".Pluralize());
            TimeSpan timeSp = new TimeSpan(2, 30, 0);
            string humTS = timeSp.Humanize();
            Console.WriteLine(humTS);
            Console.WriteLine("Personnes".Singularize());
            Console.WriteLine(122.ToWords());
            Console.WriteLine(27.ToRoman());
        }
        static void TestColorful()
        {
            Console.WriteLine("LOL", Color.White);
            int entree = 0;
            Console.WriteLine("Entrez un nombre", Color.Pink);
            entree = int.Parse(Console.ReadLine());
            Console.Write("L", Color.DarkRed);
            for (int i = 0; i < entree; i++)
            {
                Console.Write("O", Color.Aquamarine);
            }
            Console.Write("L", Color.DarkRed);
        }
        static void Main(string[] args)
        {
            TestHumain();
            TestColorful();
        }
    }
}

