using System;
using System.IO;

namespace journal_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string Date = DateTime.Today.ToString("D");

            Intro();

            while (true)
            {
                input = Console.ReadLine();
                if (input == "start" || input == "Start" || input == "START") 
                    break;


            }
            using (StreamWriter Journal = new StreamWriter(Date + ".txt", true))
            {
                Console.Clear();
                Console.WriteLine("Start writing");

                while (true)
                {
                    input = Console.ReadLine();
                    if (input == "stop" || input== "Stop" ||input== "STOP") break;
                    Journal.WriteLine(input);
                    Journal.Flush();

                }
            }
            Exit();

        }
        static void Intro()
        {
            Console.WriteLine(" Let's make a journal!");
            Console.WriteLine("type 'start' to begin writing");
            Console.WriteLine("type 'stop' to stop writing and save");

        }
        static void Exit ()
        {
            Console.Clear();
            Console.WriteLine("Push any botton to restart");
            Console.ReadKey();
        }
    }
}
