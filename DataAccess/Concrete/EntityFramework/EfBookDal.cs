using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal: IEntityRepository<Book,BookStoreContext>, IBookDal
    {
    }
}
