using System.IO;
using OnionDemo.DomainModel;
using OnionDemo.DomainServices;

namespace OnionDemo.Infrastructure
{
    public class FileBoardRepository : IBoardRepository
    {
        public void Save(Board board)
        {
            var contents = board.ToString();
            File.WriteAllText("game.txt", contents);
        }

        public Board Load()
        {
            var contents = File.ReadAllText("game.txt");
            return new Board(contents);
        }
    }
}
