namespace SystmProgramm_DZ_1
{
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.Management;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Security.Cryptography;

    internal class Program
    {
        public static int GetParentProcessId(int Id)
        {
            int parentId = 0;
            using (ManagementObject obj = new ManagementObject("win32_process.handle=" + Id.ToString()))
            {
                obj.Get();
                parentId = Convert.ToInt32(obj["ParentProcessId"]);
            }
            return parentId;
        }
        static void Main(string[] args)
        {
            int answer = -1;
            while (true)
            {
                Console.WriteLine("\nВыберите номер задания, 0 - выход");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer > 4 || answer < 0)
                {
                    Console.WriteLine("Не верный ввод");
                }
                else
                {
                    if (answer == 1)
                    {
                        Console.Clear();
                        Process proc = new Process();
                        proc.StartInfo.FileName = "notepad.exe";
                        proc.Start();
                        Console.WriteLine("Запущен процесс: " + proc.
                        ProcessName);
                        proc.WaitForExit();
                        Console.WriteLine("Процесс завершился с кодом: " +
                        proc.ExitCode);
                        Console.WriteLine("Текущий процесс имеет имя: " +
                        Process.GetCurrentProcess().ProcessName);
                    }
                    if (answer == 2)
                    {
                        Console.Clear();
                        Process proc = new Process();
                        proc.StartInfo.FileName = "notepad.exe";
                        proc.Start();
                        Console.WriteLine("Запущен процесс: " + proc.
                        ProcessName);
                        Console.WriteLine(" 1 - Ожидать завершение дочернего процесса и отображать код завершения\n 2 - принудительно завершить работу дочернего процесса");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            proc.WaitForExit();
                            Console.WriteLine("Процесс завершился с кодом: " +
                            proc.ExitCode);
                            Console.WriteLine("Текущий процесс имеет имя: " +
                            Process.GetCurrentProcess().ProcessName);
                        }
                        if (choice == 2)
                        {
                            proc.Kill();
                            Console.WriteLine("Процесс завершился с кодом: " +
                            proc.ExitCode);
                            Console.WriteLine("Текущий процесс имеет имя: " +
                            Process.GetCurrentProcess().ProcessName);
                        }
                    }
                    if (answer == 3)
                    {
                        Process proc = Process.Start("C:\\Users\\Odyss\\source\\repos\\SystmProgramm_DZ_1\\SystmProgramm_DZ_1.2\\bin\\Debug\\net6.0\\SystmProgramm_DZ_1.2.exe", new string[] { "4", "6", "+" });
                        proc.WaitForExit();
                       
                    }
                    if (answer == 4)
                    {
                        Process proc = Process.Start("C:\\Users\\Odyss\\source\\repos\\SystmProgramm_DZ_1\\SystemProgramm_DZ_1.3\\bin\\Debug\\net6.0\\SystemProgramm_DZ_1.3.exe", new string[] { "D:\\1.txt", "мама" });
                        proc.WaitForExit();
                    }
                    if (answer == 0)
                    {
                        break;
                    }
                }

            }
        }
    }
}