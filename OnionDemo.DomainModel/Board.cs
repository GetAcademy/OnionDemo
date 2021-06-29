using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionDemo.Model
{
    class Board
    {
        private readonly List<Row> _rows;

        public Board(int size)
        {
            _rows = Enumerable.Range(1, size).Select(i => new Row(size)).ToList();
        }

        public Board(string contents)
        {
            _rows = contents.Split('\n').Select(l => new Row(l)).ToList();
        }

        public void Play(int rowIndex, int columnIndex, bool isCross)
        {
            AddBlankCells();
            _rows[rowIndex].Play(columnIndex, isCross);
        }

        private void AddBlankCells()
        {
            
        }

        public override string ToString()
        {
            return string.Join('\n', _rows.Select(r => r.ToString()));
        }
    }
}
