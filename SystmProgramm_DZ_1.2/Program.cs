using System.Diagnostics;

namespace SystmProgramm_DZ_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            if (args.Length != 0)
            {

                string s0 = args[0];
                string s1 = args[1];
                string s2 = args[2];
                Console.WriteLine(s0);
                Console.WriteLine(s1);
                Console.WriteLine(s2);


                if (s2 == "+")
                {
                    int answer1 = Convert.ToInt32(s0) + Convert.ToInt32(s1);
                    Console.WriteLine("\n" + answer1);
                }
                if (s2 == "-")
                {
                    int answer1 = Convert.ToInt32(s0) - Convert.ToInt32(s1);
                    Console.WriteLine("\n" + answer1);
                }
                if (s2 == "*")
                {
                    int answer1 = Convert.ToInt32(s0) * Convert.ToInt32(s1);
                    Console.WriteLine("\n" + answer1);
                }
                if (s2 == "/")
                {
                    int answer1 = Convert.ToInt32(s0) / Convert.ToInt32(s1);
                    Console.WriteLine("\n"+answer1);
                }

            }
           
        }
        
    }
}