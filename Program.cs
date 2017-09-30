using Planar.Classes;
using System;

namespace Planar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Recipe trc = new Recipe("test", TargetPlatform.WINDOWS);
            trc.AddScript("one", @"C:\tools\one.sh");
            trc.Save();*/
            Recipe trc = Recipe.Load("test");
            Console.WriteLine($@"Recipe: {trc.Name}");
            Console.WriteLine("Scripts:");
            foreach (Script item in trc.Scripts)
            {
                Console.WriteLine($"\t - {item.Name}");
                Console.WriteLine($"\t\t - {item.OS}_{item.Arch} on {item.Platform}");
            }
            Console.ReadKey();
        }
    }
}
