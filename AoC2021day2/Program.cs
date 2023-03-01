using System.Security.Cryptography.X509Certificates;

namespace AoC2021day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(string Name, int Value)> commands;


            commands = File.ReadAllLines("Day2.txt")
                     .Select(x => x.Split())
                     .Select(x => (x[0], int.Parse(x[1])))
                     .ToList();


            //Part-1
            /*var horizontalPosition = 0;
            var depth = 0;

            foreach (var (name, value) in commands)
            {
                if (name == "forward") horizontalPosition += value;
                if (name == "down") depth += value;
                if (name == "up") depth -= value;
            }

            Console.WriteLine(horizontalPosition * depth);*/

            var horizontalPosition = 0;
            var depth = 0;
            var aim = 0; 

            foreach (var (name, value) in commands)
            {
                if (name == "forward")
                {
                    horizontalPosition += value;
                    depth += aim * value;
                }

                if (name == "down") aim += value;
                if (name == "up") aim -= value;
            }

            Console.WriteLine(horizontalPosition * depth);

        }
    }
}