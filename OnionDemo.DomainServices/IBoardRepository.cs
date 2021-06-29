using OnionDemo.DomainModel;

namespace OnionDemo.DomainServices
{
    public interface IBoardRepository
    {
        void Save(Board board);
        Board Load();
    }
}
