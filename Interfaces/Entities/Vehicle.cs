namespace Interfaces.Entities
{
    public class Vehicle
    {
        public Vehicle(string? model)
        {
            Model = model;
        }

        public string Model { get; set; }
    }
}