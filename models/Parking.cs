using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio.me_s_C_Sharp_challenge_from_a_parking_lot.models
{
public class Parking
{
    public decimal Initialprice = 0;
    public decimal PricePerHour = 0;
    private List<string> Vehicles = new List<string>();

    public Parking(decimal initialprice, decimal pricePerHour)
    {
        Initialprice = initialprice;
        PricePerHour = pricePerHour;
    }

    public void ConfigureValues()
    {
        Console.Write("Enter the input value:");
        decimal.TryParse(Console.ReadLine(), out decimal prohibited);
        Initialprice = prohibited;
        Console.SetCursorPosition(4,7);
        Console.Write("Enter the hourly rate: ");
        decimal.TryParse(Console.ReadLine(), out decimal pricePerHour);
        PricePerHour = pricePerHour;
    }

    public void AddVehicle()
    {        
        Console.Write("Enter the vehicle license plate:");
        Vehicles.Add(Console.ReadLine());
    }

    public void RemoveVehicle()
    {
        Console.Write("Enter the card to remove:");
        string plate = Console.ReadLine();

        if (Vehicles.Any(x => x.ToUpper() == plate.ToUpper()))
        {
            Console.SetCursorPosition(4,7);
            Console.Write("How many hours the vehicle remained:");
            int.TryParse(Console.ReadLine(), out int horas);
            decimal valorTotal = horas * PricePerHour + Initialprice; 

            Console.SetCursorPosition(4,8);
            Console.WriteLine($"The vehicle {plate} was removed.");
            Console.SetCursorPosition(4,9);
            Console.WriteLine($"Total price was:$ {valorTotal.ToString("F2")}");

            Vehicles.Remove(plate);
        }
        else
        {
            Console.SetCursorPosition(4,7);
            Console.WriteLine("That vehicle is not parked here.");
        }
        Console.ReadKey();
    }

    public void ListVehicles()
    {   
        int i = 6;
        if (Vehicles.Any())
        {
            foreach (var item in Vehicles)
            {
                Console.SetCursorPosition(4,i++);
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.SetCursorPosition(4,6);
            Console.WriteLine("There are no parked vehicles.");
        }
        Console.ReadKey();
    }
}
}