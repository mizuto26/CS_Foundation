using Ex_04_03.Modules;

namespace Ex_04_03;

static class Program
{
    static void Main(string[] args)
    {
        List<Employee> list = [];

        while (true)
        {
            Console.WriteLine("社員番号を入力して下さい->");
            string input = Console.ReadLine()!;

            if (input == "End")
            {
                break;
            }

            int em_id = int.Parse(input);
            Console.WriteLine("社員名を入力して下さい->");
            string em_name = Console.ReadLine()!;
            Console.WriteLine("住所を入力して下さい->");
            string em_address = Console.ReadLine()!;

            Employee employee = new Employee(id: em_id, name: em_name, address: em_address);

            list.Add(employee);
        }

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"{list[i].ToString()}");
        }
    }
}
