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

        public void Play(Play play)
        {
            // loade objekter
            var board = _boardRepository.Load();
            // gjøre ting - selve funksjonaliten
            board.Play(play.RowIndex, play.ColIndex, play.IsCross);
            // lagre objekter
            _boardRepository.Save(board);
        }
    }
}
