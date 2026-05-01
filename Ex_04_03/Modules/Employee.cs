namespace Ex_04_03.Modules
{
    public class Employee(int id, string name, string address)
    {
        public int Id { get; set; } = id;
        public string? Name { get; set; } = name;
        public string? Address { get; set; } = address;

        public override string ToString()
        {
            return $"Employee[Id={Id},Name={Name},Address ={Address}]";
        }
    }
}