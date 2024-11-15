using System.IO.Compression;
using System.Runtime.CompilerServices;
using Multifabriken;

internal class Program
{
    //Skapar listor för varje produkt
    static List<Car> cars = new List<Car>();
    static List<Candy> candys = new List<Candy>();
    static List<Pipe> pipes = new List<Pipe>();
    static List<Oatmilk> oatmilks = new List<Oatmilk>();
    
    private static void Main(string[] args)
    {
        var run = true;

        //Startar menyn
        while (run)
        {
            Console.Clear();
            //Säkrar menyval
            int choice = GetValidInput<int>("Välkommen till multifabriken! \nVar god gör ett val: " + "\n[1] Beställ vara\n"
                                    + "[2] Visa varukorg\n"
                                    + "[3] Avsluta");

            //Skapar meny för beställning
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    choice = GetValidInput<int>("Vad vill du beställa?" + "\n[1] Bilar\n"
                                            + "[2] Godis\n"
                                            + "[3] Rör\n"
                                            + "[4] Havremjölk\n"
                                            + "[5] Tillbaka till menyn");

                    switch (choice)
                    {
                        //Beställ en bil
                        case 1:
                            Console.Clear();
                            
                            //Ber om info och säkrar
                            System.Console.WriteLine("Registreringsnummer: ");
                            string? regNr;
                            while (string.IsNullOrEmpty(regNr = Console.ReadLine()))
                            {
                                System.Console.WriteLine("Du måste ange ett registreringsnummer.");
                            }                            
                            System.Console.WriteLine("Färg: ");
                            string? colour;
                            while (string.IsNullOrEmpty(colour = Console.ReadLine()))
                            {
                                System.Console.WriteLine("Du måste ange en färg.");
                            } 
                            System.Console.WriteLine("Märke: ");
                            string? brand;
                            while (string.IsNullOrEmpty(brand = Console.ReadLine()))
                            {
                                System.Console.WriteLine("Du måste ange ett märke.");
                            }                             
                            
                            //Lägger till bilen i listan
                            cars.Add(new Car("Bil",regNr,colour,brand));
                            cars[^1].SayThanks();
                            Thread.Sleep(2000);
                            break;
                        //Beställ godis
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Smak: ");
                            string? flavour;
                            while (string.IsNullOrEmpty(flavour = Console.ReadLine()))
                            {
                                System.Console.WriteLine("Du måste ange en smak.");
                            }
                            Console.WriteLine("Antal: ");
                            double amount;
                            while (!double.TryParse(Console.ReadLine(), out amount))
                            {
                                System.Console.WriteLine("Du måste ange antal.");
                            }
                            //Lägger till i listan
                            candys.Add(new Candy("Godis", flavour, amount));
                            candys[^1].SayThanks();
                            Thread.Sleep(2000);
                            break;
                        //Beställ rör
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Diameter: ");
                            double diameter;
                            while (!double.TryParse(Console.ReadLine(), out diameter))
                            {
                                System.Console.WriteLine("Du måste ange diameter.");
                            }
                            Console.WriteLine("Längd: ");
                            double length;
                            while (!double.TryParse(Console.ReadLine(), out length))
                            {
                                System.Console.WriteLine("Du måste ange längd.");
                            }
                            //Lägger till i listan
                            pipes.Add(new Pipe("Rör", diameter, length));
                            pipes[^1].SayThanks();
                            Thread.Sleep(2000);
                            break;
                        //Beställ havremjölk
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Fetthalt: ");
                            double fatProcent;
                            while (!double.TryParse(Console.ReadLine(), out fatProcent))
                            {
                                System.Console.WriteLine("Ange endast siffror.");
                            }
                            Console.WriteLine("Litermängd: ");
                            double liter;
                            while (!double.TryParse(Console.ReadLine(), out liter))
                            {
                                System.Console.WriteLine("Ange endast siffror.");
                            }
                            //Lägger till i listan
                            oatmilks.Add(new Oatmilk("Havremjölk", fatProcent, liter));
                            oatmilks[^1].SayThanks();
                            Thread.Sleep(2000);
                            break;
                        //Gå tillbaka till huvudmenyn
                        case 5:
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Du måste göra ett giltigt val.");
                            Thread.Sleep(1000);
                            break;
                    }
                    break;
                //Visar varukorgen eller meddelande om den är tom
                case 2:
                    Console.Clear();
                    Console.WriteLine("Varukorg:\n");

                    if(cars.Count == 0 && candys.Count == 0 && pipes.Count == 0 && oatmilks.Count == 0)
                    {
                        System.Console.WriteLine("Kundvagnen är tom.");
                        System.Console.WriteLine("Tryck på valfri knapp för att återgå till menyn.");
                        Console.ReadKey();
                    }
                    else
                    {
                        foreach (var car in cars)
                        {
                            System.Console.WriteLine(car.GetInfo());
                        }
                        foreach (var candy in candys)
                        {
                            System.Console.WriteLine(candy.GetInfo());
                        }
                        foreach (var pipe in pipes)
                        {
                            System.Console.WriteLine(pipe.GetInfo());
                        }
                        foreach (var oatmilk in oatmilks)
                        {
                            System.Console.WriteLine(oatmilk.GetInfo());
                        }
                        System.Console.WriteLine("Tryck på valfri knapp för att återgå till menyn.");
                        Console.ReadKey();
                    }
                    break;                                
                //Avslutar programmet
                case 3:
                    Console.Clear();
                    Console.WriteLine("Tack för den här gången!");
                    Thread.Sleep(1000);
                    run = false;
                    break;

                default:
                    Console.WriteLine("Du måste göra ett giltigt val.");
                    Thread.Sleep(1000);
                    break;
            }

        }
    }
    //Metod för att validera menyval
    private static T GetValidInput<T>(string inputReading)
    {
        Console.WriteLine(inputReading);
        while (true)
        {
            //Säkerställer att input inte är null
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Du måste ange ett värde. Försök igen.");
                continue;
            }
            try
            {
                return (T)Convert.ChangeType(input, typeof(T));
            }
            catch
            {
                Console.WriteLine("Du måste göra ett giltigt val. Försök igen.");
            }
        }
    }
}