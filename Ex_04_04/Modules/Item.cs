namespace Ex_04_04.Modules
{
    public class Item(int id, string name, int price)
    {
        public int Id { get; set; } = id;
        public string? Name { get; set; } = name;
        public int Price { get; set; } = price;


        public override string ToString()
        {
            return $"Item[Id={Id},Name={Name},Price ={Price}]";
        }
    }
}
