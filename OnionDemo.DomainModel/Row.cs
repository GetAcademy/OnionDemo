using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionDemo.Model
{
    class Row
    {
        private List<Square> _squares;

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
