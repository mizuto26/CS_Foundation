using Ex_04_05.Modules;
namespace Ex_04_05;

static class Program
{
    static void Main(string[] args)
    {
        List<string> datas = [];
        string fileName = "exercise05.txt";

        while (true)
        {
            Console.WriteLine("書き込むデータを入力してください->");
            string data = Console.ReadLine()!;

            if (data == "End")
            {
                break;
            }

            datas.Add(data);
        }

        TextFileAccessor.Write(fileName: fileName, datas: datas);
        Console.WriteLine("ファイルにデータを書き込みました。");

        TextFileAccessor.ReadAndPrint(fileName: fileName);
        Console.WriteLine("ファイルのデータを読み取りました。");
    }
}
