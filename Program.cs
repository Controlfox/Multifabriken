var run = true;

while(run)
{
    System.Console.WriteLine("Välkommen till multifabriken! \nVar god gör ett val: ");
    System.Console.WriteLine("[1] Beställ vara\n"
                            + "[2] Visa varukorg\n"
                            + "[3] Avsluta");

    int choice = int.Parse(Console.ReadLine()); //SÄKRA DEN HÄR

    switch(choice)
    {
        case 1:
        Console.Clear();
            System.Console.WriteLine("Vad vill du beställa?");
            System.Console.WriteLine("[1] Bilar\n"
                                    + "[2] Godis\n"
                                    + "[3] Rör\n"
                                    + "[4] Havremjölk\n"
                                    + "[5] Tillbaka till menyn");
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.Clear();
                    System.Console.WriteLine("Registreringsnummer: ");
                    string? regNr = Console.ReadLine();
                    System.Console.WriteLine("Färg: ");
                    string? colour = Console.ReadLine();
                    System.Console.WriteLine("Bilmärke: ");
                    string? brand = Console.ReadLine();
                    System.Console.WriteLine("Din vara har lagts till i varukorgen."); //GÖR OM TILL GENERELLT TACKMEDDELANDE
                    Thread.Sleep(1000);
                    break;
                case 2:
                    Console.Clear();
                    System.Console.WriteLine("Smak: ");
                    string? flavour = Console.ReadLine();
                    System.Console.WriteLine("Antal: ");
                    int amount = int.Parse(Console.ReadLine()); //SÄKRA DEN HÄR
                    System.Console.WriteLine("Din vara har lagts till i varukorgen."); //GÖR OM TILL GENERELLT TACKMEDDELANDE
                    Thread.Sleep(1000);
                    break;
                case 3:
                    Console.Clear();
                    System.Console.WriteLine("Diameter: ");
                    int diameter = int.Parse(Console.ReadLine()); //SÄKRA DEN HÄR
                    System.Console.WriteLine("Längd: ");
                    int length = int.Parse(Console.ReadLine()); //SÄKRA DEN HÄR
                    System.Console.WriteLine("Din vara har lagts till i varukorgen."); //GÖR OM TILL GENERELLT TACKMEDDELANDE
                    Thread.Sleep(1000);
                    break;
                case 4:
                    Console.Clear();
                    System.Console.WriteLine("Fetthalt: ");
                    int fatProcent = int.Parse(Console.ReadLine()); //SÄKRA DEN HÄR
                    System.Console.WriteLine("Litermängd: ");
                    int liter = int.Parse(Console.ReadLine()); //SÄKRA DEN HÄR
                    System.Console.WriteLine("Din vara har lagts till i varukorgen."); //GÖR OM TILL GENERELLT TACKMEDDELANDE
                    Thread.Sleep(1000);
                    break;
                case 5:
                    break;
                default:
                    Console.Clear();
                    System.Console.WriteLine("Du måste göra ett giltigt val.");
                    Thread.Sleep(1000);
                    break;
            }
            break;

            case 2:
                System.Console.WriteLine("Varukorg:\n");
                break;

            case 3:
                System.Console.WriteLine("Tack för den här gången!");
                Thread.Sleep(1000);
                run = false;
                break;
    }

}