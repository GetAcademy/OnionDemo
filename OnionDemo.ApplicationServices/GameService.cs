using OnionDemo.DomainModel;
using OnionDemo.DomainServices;

namespace OnionDemo.ApplicationServices
{
    public class GameService
    {
        private readonly IBoardRepository _boardRepository;

        public GameService(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        public Board Play(Play play)
        {
            // loade objekter
            var board = _boardRepository.Load();
            // gjøre ting - selve funksjonaliten
            board.Play(play.RowIndex, play.ColIndex, play.IsCross);
            // lagre objekter
            _boardRepository.Save(board);
            return board;
        }

        public Board New()
        {
            var board = new Board(10);
            // lagre objekter
            _boardRepository.Save(board);
            return board;
        }

        public void Save(Board board)
        {
            _boardRepository.Save(board);
        }

        public Board Load()
        {
            return _boardRepository.Load();
        }
    }
}
