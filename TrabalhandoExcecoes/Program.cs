using TrabalhandoExcecoes.Entities;

Console.Write("Room number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Check-in date (dd/mm/yyyy): ");
DateTime checkIn = DateTime.Parse(Console.ReadLine());
Console.Write("Check-out date (dd/mm/yyyy): ");
DateTime checkOut = DateTime.Parse(Console.ReadLine());

if (checkOut <= checkIn)
{
    Console.WriteLine("Error in reservation: Check-Out date must de after Check-In date.")
}
else
{
    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the resercation: ");
    Console.Write("Check-in date (dd/mm/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/mm/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    DateTime now = DateTime.Now;
    if (checkIn < now || checkOut < now)
    {
        Console.WriteLine("Error in reservation: Reservation dates for update must de future dates!");
    }
    else if (checkOut <= checkIn)
    {
        Console.WriteLine("Error in reservation: Check-Out date must de after Check-In date.")
    }
    else 
    {
        reservation.UpdateDates(checkIn, checkOut);
        Console.WriteLine("Reservation: " + reservation);
    }
}