using Multifabriken;

internal class Program
{
    static List<Car> cars = new List<Car>();
    static List<Candy> candys = new List<Candy>();
    static List<Pipe> pipes = new List<Pipe>();
    static List<Oatmilk> oatmilks = new List<Oatmilk>();
    
    private static void Main(string[] args)
    {
        var run = true;

        while (run)
        {
            Console.WriteLine("Välkommen till multifabriken! \nVar god gör ett val: ");
            Console.WriteLine("[1] Beställ vara\n"
                                    + "[2] Visa varukorg\n"
                                    + "[3] Avsluta");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                System.Console.WriteLine("Du måste ange en siffra.");
            }

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Vad vill du beställa?");
                    Console.WriteLine("[1] Bilar\n"
                                            + "[2] Godis\n"
                                            + "[3] Rör\n"
                                            + "[4] Havremjölk\n"
                                            + "[5] Tillbaka till menyn");

                    while (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        System.Console.WriteLine("Du måste ange en siffra.");
                    }

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Registreringsnummer: ");
                            string? regNr = Console.ReadLine();
                            Console.WriteLine("Färg: ");
                            string? colour = Console.ReadLine();
                            Console.WriteLine("Bilmärke: ");
                            string? brand = Console.ReadLine();
                            cars.Add(new Car("Bil:",regNr,colour,brand));
                            Console.WriteLine("Din vara har lagts till i varukorgen."); //GENERELLT MEDDELANDE
                            Thread.Sleep(1000);
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Smak: ");
                            string? flavour = Console.ReadLine();
                            Console.WriteLine("Antal: ");
                            double amount;
                            while (!double.TryParse(Console.ReadLine(), out amount))
                            {
                                System.Console.WriteLine("Du måste ange antal.");
                            }
                            candys.Add(new Candy("Godis:", flavour, amount));
                            Console.WriteLine("Din vara har lagts till i varukorgen."); //GÖR OM TILL GENERELLT TACKMEDDELANDE
                            Thread.Sleep(1000);
                            break;
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
                            pipes.Add(new Pipe("Rör:", diameter, length));
                            Console.WriteLine("Din vara har lagts till i varukorgen."); //GÖR OM TILL GENERELLT TACKMEDDELANDE
                            Thread.Sleep(1000);
                            break;
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
                            oatmilks.Add(new Oatmilk("Havremjölk:", fatProcent, liter));
                            Console.WriteLine("Din vara har lagts till i varukorgen."); //GÖR OM TILL GENERELLT TACKMEDDELANDE
                            Thread.Sleep(1000);
                            break;
                        case 5:
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Du måste göra ett giltigt val.");
                            Thread.Sleep(1000);
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("Varukorg:\n");
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
                    if(cars.Count == 0 && candys.Count == 0 && pipes.Count == 0 && oatmilks.Count == 0)
                    {
                        System.Console.WriteLine("Kundvagnen är tom.");
                    }                                      
                    break;

                case 3:
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
}