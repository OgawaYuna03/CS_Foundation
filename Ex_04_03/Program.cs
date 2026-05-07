using Ex_04_03.Modules;
namespace Ex_04_03;

static class Program
{
    static void Main(string[] args)
    {
        List<Employee> employee = new List<Employee> ();
        while (true)
        {
            Console.WriteLine("社員番号を入力して下さい->");
            string Id = Console.ReadLine();
            if (Id == "End")
            {
                break;
            }
            Console.Write("社員名を入力して下さい->");
            string adress = Console.ReadLine();
            Console.Write("住所を入力して下さい->");
            string adress = Console.ReadLine();
            employee employee = new employee(int.Parse(id), name, adress);
            employees.Add(employee);

        }
        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee);
        }

    }
}
