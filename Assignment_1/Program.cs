using Assignment_1.Contexts;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using BookstoreContext dbContext = new BookstoreContext();
        }
    }
}
