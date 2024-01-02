using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        List<Book> GetById(int id);
        List<Book> GetByAuthorId(int authorId);
        void Add(Book book);
        void Delete(Book book);
        void Update(Book book);
    }
}
