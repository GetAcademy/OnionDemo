using System;
using System.IO;
using OnionDemo.DomainModel;

namespace OnionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board(10);
            while (true)
            {
                Console.Clear();
                Console.Write("Kommando: ");
                var command = Console.ReadLine();

                if (command.StartsWith("spill "))
                {
                    var parts = command.Split(' ');
                    var rowIndex = Convert.ToInt32(parts[1]);
                    var colIndex = Convert.ToInt32(parts[2]);
                    board.Play(rowIndex, colIndex, true);
                }
                else if (command.StartsWith("save"))
                {
                    var contents = board.ToString();
                    File.WriteAllText("game.txt", contents);
                }
                else if (command.StartsWith("load"))
                {
                    var contents = File.ReadAllText("game.txt");
                    board = new Board(contents);
                }

                Console.WriteLine(board.ToString());
            }
        }
    }
}
