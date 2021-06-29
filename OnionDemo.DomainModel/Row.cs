using System.Collections.Generic;
using System.Linq;

namespace OnionDemo.DomainModel
{
    public class Row
    {
        private readonly List<Square> _squares;

        public Row(int squareCount)
        {
            _squares = Enumerable.Range(1, squareCount).Select(i => new Square()).ToList();
        }

        public Row(string contents)
        {
            _squares = contents.ToCharArray().Select(c => new Square(c)).ToList();

        }

        public void Play(in int columnIndex, bool isCross)
        {
            _squares[columnIndex].Play(isCross);
        }

        public override string ToString()
        {
            var array = _squares.Select(s => s.DisplayChar).ToArray();
            return new string(array);
        }
    }
}
