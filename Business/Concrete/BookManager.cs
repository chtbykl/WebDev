using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BookManager:IBookService
    {
        private IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public List<Book> GetAll()
        {
            return _bookDal.GetList().ToList();
        }

        public List<Book> GetById(int id)
        {
            return _bookDal.GetList(b => b.Id == id).ToList();
        }

        public List<Book> GetByAuthorId(int authorId)
        {
            return _bookDal.GetList(b => b.AuthorId == authorId).ToList();
        }

        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}
