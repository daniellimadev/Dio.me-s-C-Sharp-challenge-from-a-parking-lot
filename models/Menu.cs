namespace Dio.me_s_C_Sharp_challenge_from_a_parking_lot.models;

public class Menu
{
    private Parking Parking {get;set;}

    public Menu(Parking parking)
    {
        Parking = parking;
    }

    public void InicializeMenu()
    {
        string option = string.Empty;

        while(option != "5")
        {
            DrawMenu();
            ViewOptions();
            option = Console.ReadLine();
            ExecuteOptions(option);
        };

    }

    public void ExecuteOptions(string option)
    {

        switch (option)
        {
            case "1":
                DrawMenu();
                PrintHeader("Setting initial values");
                Console.SetCursorPosition(4,6);
                Parking.ConfigureValues();
            break;

            case "2":
                DrawMenu();
                PrintHeader("Added vehicles in the parking lot");
                Console.SetCursorPosition(4,6);
                Parking.AddVehicle();
            break;

            case "3":
                DrawMenu();
                PrintHeader("Removing vehicles from the parking lot");
                Console.SetCursorPosition(4,6);
                Parking.RemoveVehicle();
            break;

            case "4":
                DrawMenu();
                PrintHeader("Lists of parked vehicles");
                Parking.ListVehicles();
            break;
            case "5":
                DrawMenu();
                ViewExit();
                Console.ReadKey();
            break;

            default:
                Console.WriteLine("Invalid option");
            break;
        }        
    }

    public void DrawMenu()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.Clear();
        Console.Write("+");
        PrintCaracter(50, "-");
        Console.WriteLine("+");

        for(int i = 0; i<12; i++)
        {
            Console.Write("|");
            PrintCaracter(50, " ");
            Console.WriteLine("|");
        }

        Console.Write("+");
        PrintCaracter(50, "-");
        Console.WriteLine("+"); 
    }
    private void PrintHeader(string title)
    {
        Console.SetCursorPosition(4,1);
        Console.WriteLine(title);
        Console.SetCursorPosition(1,2);
        PrintCaracter(50, "-");
        Console.SetCursorPosition(7,3);
        Console.WriteLine($"Prohibited: {Parking.Initialprice.ToString("F2")}  |  Price per hour: {Parking.PricePerHour.ToString("F2")}");
        Console.SetCursorPosition(1,4);
        PrintCaracter(50, "-");
    }
    public void ViewOptions()
    {

        PrintHeader("Welcome to the parking system!");

        Console.SetCursorPosition(3,5);
        Console.WriteLine("01 - Configure");
        Console.SetCursorPosition(3,6);
        Console.WriteLine("02 - Register");
        Console.SetCursorPosition(3,7);
        Console.WriteLine("03 - To remove");
        Console.SetCursorPosition(3,8);
        Console.WriteLine("04 - List");
        Console.SetCursorPosition(3,9);
        Console.WriteLine("05 - Close");
        Console.SetCursorPosition(3,10);
        Console.Write("Option: ");
    }
    
    public void ViewExit()
    {

        Console.SetCursorPosition(13,1);
        Console.WriteLine("Parking System");
        Console.SetCursorPosition(1,2);
        PrintCaracter(50, "-");
        Console.SetCursorPosition(7,7);
        Console.WriteLine($"Thank you for using our system!!!");
        Console.SetCursorPosition(0,14);

    
    }
    private void PrintCaracter(int qtd, string item)
    {
        for(int i = 0; i<qtd; i++)
        {
            Console.Write(item);
        }
    }
}