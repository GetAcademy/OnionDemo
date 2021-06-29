using System;
using System.IO;
using OnionDemo.ApplicationServices;
using OnionDemo.DomainModel;
using OnionDemo.Infrastructure;

namespace OnionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileBoardRepository = new FileBoardRepository();
            var gameService = new GameService(fileBoardRepository);

            var board = gameService.Load();
            Console.WriteLine(board.ToString());

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
                    var play = new Play(rowIndex, colIndex, true);
                    board = gameService.Play(play);
                }
                else if (command.StartsWith("new"))
                {
                    board = gameService.New();
                }

                Console.WriteLine(board.ToString());
            }
        }
    }
}
