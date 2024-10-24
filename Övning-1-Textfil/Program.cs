using System;
using System.IO;

namespace Textfil
{
    class Program
    {
        static void Main()
        {
            int input = 0;
            while (true)
            {
                Console.WriteLine("1. Skriv till fil");
                Console.WriteLine("2. Läs fil");
                Console.WriteLine("3. Avsluta");

                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Write();
                        break;
                    case 2:
                        Read();
                        break;
                    case 3:
                        File.Delete("Textfil.txt");
                        return;
                    default: 
                        Console.WriteLine("Ange ett gilitgt alternativ");
                        break;
                }
            }
        }

        static void Write()
        {
            StreamWriter sW = new("Textfil.txt", true);
            Console.WriteLine();
            Console.Write("Input: ");
            sW.WriteLine(Console.ReadLine());
            sW.Close();
        }

        static void Read()
        {
            try
            {
                StreamReader sR = new("Textfil.txt");
                Console.WriteLine(sR.ReadToEnd());
                sR.Close();
            }
            catch (FileNotFoundException) 
            {
                Console.WriteLine("Filen finns inte, skapa filen först.");
            }
        }
    }
}