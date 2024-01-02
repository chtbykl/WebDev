using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new() 
    // where T : class, IEntity, new() bu yapıya generic constrain denir.
    //where T : ile verilen T tipini sınırlandırırsınız
    // class, T nin sadece referans tip olabileceğni söyler
    //IEntity, T bir IEntity implamantasyonu olacak demek. yani verilen t tipi IEntity ile imlemente edilmiş olacak
    // new(), verilen tip newlenebilir olacak, yani bir interface verilemez, sadece sınıflar verilebilir.
    {
        T Get(Expression<Func<T, bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
