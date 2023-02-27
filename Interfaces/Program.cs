

using Interfaces.Entities;
using Interfaces.Services;
using System.Globalization;

Console.WriteLine("Enter rental data: ");
Console.WriteLine("Car model:");
string model = Console.ReadLine();
Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.WriteLine("Enter price per hour: ");
double hour = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
Console.WriteLine("Enter price per day: ");
double day = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalServices rentalServices = new RentalServices(hour, day, new BrasilTaxServices);

rentalServices.ProcessInvoice(carRental);
Console.WriteLine("Invoice:");
Console.WriteLine(carRental.Invoice);