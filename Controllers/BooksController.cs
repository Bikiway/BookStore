using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var books = GetSampleBooks();
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = GetSampleBooks().FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        private List<Book> GetSampleBooks()
        {
            return new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "O Alquimista",
                    Author = "Paulo Coelho",
                    Description = "Uma f�bula sobre seguir os seus sonhos e encontrar o seu destino.",
                    Price = 29.90m,
                    ImageUrl = "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=300&h=400&fit=crop",
                    Category = "Fic��o",
                    Stock = 15,
                    PublishedDate = new DateTime(1988, 1, 1),
                    Rating = 4.5,
                    ReviewCount = 1250
                },
                new Book
                {
                    Id = 2,
                    Title = "1984",
                    Author = "George Orwell",
                    Description = "Um romance dist�pico sobre totalitarismo e vigil�ncia.",
                    Price = 34.90m,
                    ImageUrl = "https://images.unsplash.com/photo-1495640388908-05fa85288e61?w=300&h=400&fit=crop",
                    Category = "Fic��o Cient�fica",
                    Stock = 8,
                    PublishedDate = new DateTime(1949, 6, 8),
                    Rating = 4.8,
                    ReviewCount = 2100
                },
                new Book
                {
                    Id = 3,
                    Title = "Dom Casmurro",
                    Author = "Machado de Assis",
                    Description = "Um cl�ssico da literatura brasileira sobre ci�me e d�vida.",
                    Price = 24.90m,
                    ImageUrl = "https://images.unsplash.com/photo-1481627834876-b7833e8f5570?w=300&h=400&fit=crop",
                    Category = "Literatura Brasileira",
                    Stock = 12,
                    PublishedDate = new DateTime(1899, 1, 1),
                    Rating = 4.2,
                    ReviewCount = 890
                },
                new Book
                {
                    Id = 4,
                    Title = "Sapiens",
                    Author = "Yuval Noah Harari",
                    Description = "Uma breve hist�ria da humanidade desde a Idade da Pedra at� a era digital.",
                    Price = 42.90m,
                    ImageUrl = "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?w=300&h=400&fit=crop",
                    Category = "Hist�ria",
                    Stock = 20,
                    PublishedDate = new DateTime(2011, 1, 1),
                    Rating = 4.7,
                    ReviewCount = 3200
                },
                new Book
                {
                    Id = 5,
                    Title = "O Pequeno Pr�ncipe",
                    Author = "Antoine de Saint-Exup�ry",
                    Description = "Uma hist�ria po�tica sobre amizade, amor e a natureza humana.",
                    Price = 19.90m,
                    ImageUrl = "https://images.unsplash.com/photo-1512820790803-83ca734da794?w=300&h=400&fit=crop",
                    Category = "Infantil",
                    Stock = 25,
                    PublishedDate = new DateTime(1943, 4, 6),
                    Rating = 4.6,
                    ReviewCount = 1800
                },
                new Book
                {
                    Id = 6,
                    Title = "Clean Code",
                    Author = "Robert C. Martin",
                    Description = "Um manual sobre como escrever c�digo limpo e manuten�vel.",
                    Price = 89.90m,
                    ImageUrl = "https://images.unsplash.com/photo-1515879218367-8466d910aaa4?w=300&h=400&fit=crop",
                    Category = "Tecnologia",
                    Stock = 10,
                    PublishedDate = new DateTime(2008, 8, 1),
                    Rating = 4.9,
                    ReviewCount = 950
                }
            };
        }
    }
}