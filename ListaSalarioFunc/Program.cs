// See https://aka.ms/new-console-template for more information
using ListaSalarioFunc;

Console.Write("Who many employees will be registred? ");
var n = int.Parse(Console.ReadLine());

List<Employee> employee = new List<Employee>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Employee #{i}:");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = (Console.ReadLine());
    Console.Write("Id: ");
    double salary = double.Parse(Console.ReadLine());
    employee.Add(new Employee(id, name, salary));
    Console.WriteLine();
}

Console.Write("Enter the employee id that will have salary increase : ");
int searchId = int.Parse(Console.ReadLine());

Employee emp = employee.Find(x => x.Id == searchId);
if (emp != null)
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine());
    emp.IncreaseSalary(percentage);
}
else
{
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine();
Console.WriteLine("Updated list of employees:");
foreach (Employee obj in employee)
{
    Console.WriteLine(obj);
}