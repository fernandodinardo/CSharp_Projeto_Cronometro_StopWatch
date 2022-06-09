using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando o Start ara testar o Startwatch até 6 segs.
            //Start(6);

            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            System.Console.WriteLine("");
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("My name is Fernando Di Nardo L.");
            System.Console.WriteLine("---");
            System.Console.WriteLine("");
            Console.WriteLine("### Bem vindo ao Aplicativo SmartWatch ###");
            System.Console.WriteLine("");

            Console.WriteLine("S = Segundos. => 10s = 10 segundos.");
            Console.WriteLine("M = Minutos. => 1m = 1 minuto.");
            Console.WriteLine("0 = Sair da Aplicação.");
            System.Console.WriteLine("");

            Console.WriteLine("Quanto tempo deseja contar?");
            System.Console.WriteLine("");

            // .ToLower() = converte todos os caracteres para MINUSCULO.
            string data = Console.ReadLine().ToLower();

            /*
            Exemplo de Substring:
            char type = char.Parse(data.Substring(1,1));
            */

            char type = char.Parse(data.Substring(data.Length - 1, 1));

            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            System.Console.WriteLine("");
            System.Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            System.Console.WriteLine("");
            System.Console.WriteLine("Set...");
            Thread.Sleep(1000);
            System.Console.WriteLine("");
            System.Console.WriteLine("GO!!!");
            Thread.Sleep(2500);
            System.Console.WriteLine("");

            Start(time);
        }

        static void Start(int time)
        {

            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(999);
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado!!!");
            Thread.Sleep(1500);
            System.Console.WriteLine("");
            Console.WriteLine("..retornando ao Menu.");
            Thread.Sleep(1500);
            System.Console.WriteLine("");

            Menu();
        }
    }
}
