namespace Ex_04_05.Modules
{
    public class TextFileAccessor
    {
        public static void Write(string fileName, List<string> datas)
        {
            StreamWriter? writer = null;
            try
            {
                writer = new StreamWriter(fileName);

                for (int i = 0; i < datas.Count; i++)
                {
                    writer.WriteLine($"{datas[i]}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                writer?.Close();
            }
        }

        public static void ReadAndPrint(string fileName)
        {
            StreamReader? reader = null;
            try
            {
                reader = new StreamReader(fileName);
                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                reader?.Close();
            }
        }
    }
}
