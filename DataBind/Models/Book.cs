using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBind.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set;}
        public string Author { get; set;}
        public string CoverImage { get; set; }


    }
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book {BookId=1, Title="Vulpate", Author="Oliver", CoverImage="/Assets/1.jfif"});
            books.Add(new Book { BookId = 2, Title = "Mazim", Author = "Kemei", CoverImage="/Assets/2.jpg" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Wahome", CoverImage="/Assets/3.png" });
            books.Add(new Book { BookId = 4, Title = "Etiam", Author = "Kipchoge", CoverImage="/Assets/4.jfif" });
            books.Add(new Book { BookId = 5, Title = "Feugait Eros Libex", Author = "Prudence", CoverImage="/Assets/5.jpg" });
            books.Add(new Book { BookId = 6, Title = "NonummyErat", Author = "kelly", CoverImage= "/Assets/6.jpg" });
            books.Add(new Book { BookId = 7, Title = "Nostrud", Author = "Susan", CoverImage= "/Assets/7.jfif" });
            books.Add(new Book { BookId = 8, Title = "Per Modo", Author = "Belinda", CoverImage= "Assets/8.jpg" });
            books.Add(new Book { BookId = 9, Title = "Suscipit Ad", Author = "David", CoverImage= "Assets/9.jpg" });
            books.Add(new Book { BookId = 10, Title = "Erat", Author = "Kenneth", CoverImage="Assets/10.jpg" });
            books.Add(new Book { BookId = 11, Title = "Decima", Author = "Wanyama",CoverImage = "Assets/11.jpg" });
            books.Add(new Book { BookId = 12, Title = "consequat", Author = "Messi", CoverImage="Assets/12.jpg" });
            books.Add(new Book { BookId = 13, Title = "Aliquip", Author = "CR7", CoverImage= "Assets/13.jpg" });
            
            return books;
        }
    }
}
