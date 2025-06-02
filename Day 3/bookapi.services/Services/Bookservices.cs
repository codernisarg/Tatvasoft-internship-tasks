using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class Bookservices
    {
        private List<book> _books;

        public Bookservices()
        {
            _books = new List<book>();
        }

        public void Addbook(book book)
        {
            _books.Add(book);
        }

        public List<book> getall()
        {
            return _books;
        }

        public book? getbyid(int id)
        {
            return _books.Find(x => x.Id == id);
        }
    }
}
