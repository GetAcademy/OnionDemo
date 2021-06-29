namespace OnionDemo.DomainModel
{
    public class Square
    {
        public char? Content { get; private set; }
        public char DisplayChar => Content ?? ' ';

        public Square()
        {
            
        }

        public Square(char c)
        {
            Content = c == ' ' ? (char?)null : c;
        }

        public void Play(bool isCross)
        {
            Content = isCross ? 'x' : 'o';
        }
    }
}
