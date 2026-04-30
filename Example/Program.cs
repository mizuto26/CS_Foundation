Warrior warrior = new Warrior();

warrior.name = "ユータ";
warrior.hp = 10;// 別なクラスから見えないのでコンパイルエラーになる

warrior.Greet1();
warrior.Greet2();// 別なクラスから見えないのでコンパイルエラーになる

/// <summary>
/// 戦士を表すクラス
/// </summary>
public class Warrior
{
    public string name;     // 名前を表すフィールド
    private int hp = 10;    // 体力を表すフィールド
    /// <summary>
    /// 挨拶を行うメソッド
    /// </summary>
    public void Greet1()
    {
        Console.WriteLine($"{name}:hello!");
    }
    private void Greet2()
    {
        Console.WriteLine($"{name}:hi!");
    }
}