namespace SystemProgramm_DZ_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                string parth = File.ReadAllText(args[0]);
                string text = args[1];
                Console.WriteLine("============================");
                var split = parth.Split(new Char[] { ' ', '.', ',', ':' }).ToList();
                int count = 0;
                foreach (var item in split)
                {
                    if (item == text)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Слово встречается {count} раз(а)");
            }
        }
    }
}