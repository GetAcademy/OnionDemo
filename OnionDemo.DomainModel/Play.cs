namespace OnionDemo.DomainModel
{
    public class Play
    {
        public int RowIndex { get; }
        public int ColIndex { get; }
        public bool IsCross { get; }

        public Play(int rowIndex, int colIndex, bool isCross)
        {
            RowIndex = rowIndex;
            ColIndex = colIndex;
            IsCross = isCross;
        }
    }
}
