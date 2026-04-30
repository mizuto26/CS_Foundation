Warrior warrior = new Warrior();
warrior.Greet();//Humanクラスのメソッドの呼び出し
warrior.Attack();//Warriorクラスのメソッドの呼び出し

/// <summary>
/// 人物を表すクラス
/// </summary>
public class Human
{
    public string? Name { get; set; }
    public int Hp { get; private set; }

    public void Greet()
    {
        Console.WriteLine("Hi!");
    }

    public void Defence(int damage)
    {
        Hp -= damage;
    }
}

/// <summary>
/// 戦士を表すクラス
/// </summary>
public class Warrior : Human
{
    public int Ap { get; set; } = 5;
    public int Dp { get; set; }

    public void Attack()
    {
        Console.WriteLine("戦士は攻撃した！");
        Console.WriteLine($"{Ap}のダメージを与えた。");
    }
}