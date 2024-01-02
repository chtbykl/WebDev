using Core.Entities;

namespace Entities.Concrete
{
    public class Book: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public decimal Price { get; set; }
    }
}
