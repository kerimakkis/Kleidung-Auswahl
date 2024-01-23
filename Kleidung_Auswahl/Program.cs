using System;

namespace _02.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie Bitte Temperatur ein:");
            int temperature = int.Parse(Console.ReadLine());
            Console.WriteLine("welche zeitraum der Tag sind sie?(Morgen,Nachmittag, Abend):");
            string zeitderTag = Console.ReadLine();

            string kleidung = string.Empty;
            string shuhe = "";

            if (temperature >= 10 && temperature <= 18)
            {
                switch (zeitderTag)
                {
                    case "Morgen":
                        kleidung = "Sweatshirt";
                        shuhe = "Sneaker";
                        break;
                    case "Nachmittag":
                    case "Abend":
                        kleidung = "Shirt";
                        shuhe = "Moccasinen";
                        break;
                }
            }
            else if (temperature > 18 && temperature <= 24)
            {
                switch (zeitderTag)
                {
                    case "Morgen":
                        kleidung = "Shirt";
                        shuhe = "Moccasin";
                        break;
                    case "Afternoon":
                        kleidung = "T-Shirt";
                        shuhe = "Sandalen";
                        break;
                    case "Evening":
                        kleidung = "Shirt";
                        shuhe = "Moccasinen";
                        break;
                }
            }
            else if (temperature >= 25)
            {
                switch (zeitderTag)
                {
                    case "Morgen":
                        kleidung = "T-Shirt";
                        shuhe = "Sandalen";
                        break;
                    case "Nachmittag":
                        kleidung = "T-Shirt";
                        shuhe = "Flipflop";
                        break;
                    case "Abend":
                        kleidung = "Shirt";
                        shuhe = "Moccasinen";
                        break;
                }
            }

            Console.WriteLine($"Es ist  {temperature} Grad , ziehe deine {kleidung} und {shuhe}um.");
        }
    }
}

