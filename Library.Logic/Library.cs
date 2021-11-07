using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Entities;

namespace Library.Logic
{
    public static class Library
    {
        public static List<Book> Books { get; set; } = new List<Book>();
        static Library()
        {
            Books.Add(new Book { Id = 1, Author = "Lior Shlein", DatePublished = new DateTime(2009, 05, 17) });
            Books.Add(new Book
            {
                Id = 8567,
                Author = "Yogev Poren",
                DatePublished = new DateTime(2003, 03, 27)
            });

            Books.Add(new Book { Id = 56, Author = "Arthur Conan Doyle", DatePublished = new DateTime(1887, 04, 20) });
            Books.Add(new Book { Id = 2, Author = "Oda", Name = "One Peace", DatePublished = new DateTime(2008, 03, 24) });
            Books.Add(new Book { Id = 7101, Author = "Lev Tolstoy", DatePublished = new DateTime(1962, 05, 17), Name = "War and Pease", NumberOfPages = 780, NumberOfCopies = 2 });
            Books.Add(new Book { Id = 7102, Author = "O'Henry", DatePublished = new DateTime(1932, 12, 17), Name = "Novells", NumberOfPages = 360, NumberOfCopies = 2 });
            Books.Add(new Book { Id = 7103, Author = "Arthur Heily", DatePublished = new DateTime(1999, 11, 17), Name = "Hotel", NumberOfPages = 260, NumberOfCopies = 3 });
            Books.Add(new Book { Id = 1, Author = "Marcel Proust", DatePublished = new DateTime(2009, 05, 17), Name = "In Search of Lost Time", NumberOfPages = 525, NumberOfBorrowedOut = 3 });
            Books.Add(new Book { Id = 2, Author = "Miguel de Cervantes", DatePublished = new DateTime(1605, 03, 02), Name = "Miguel de Cervantes", NumberOfPages = 400, NumberOfBorrowedOut = 2 });
            Books.Add(new Book { Id = 3, Author = "Gabriel Garcia Marquez", DatePublished = new DateTime(2013, 07, 05), Name = "One Hundred Years of Solitude", NumberOfPages = 321, NumberOfBorrowedOut = 5 });
            Books.Add(new Book { Id = 4, Author = "Leo Tolstoy", DatePublished = new DateTime(1980, 05, 15), Name = "War and Peace", NumberOfPages = 900, NumberOfBorrowedOut = 15 });
            Books.Add(new Book { Id = 5, Author = "Fyodor Dostoyevsky", DatePublished = new DateTime(1993, 05, 17), Name = "Crime and Punishment", NumberOfPages = 276, NumberOfBorrowedOut = 6 });
            Books.Add(new Book { Id = 987, ISBN = new Guid(), Author = "Mozes", Name = "Efshar Gam Bly Qavier", NumberOfPages = 321, NumberOfCopies = 10, NumberOfBorrowedOut = 7, DatePublished = new DateTime(1947, 02, 01) });
            Books.Add(new Book { Id = 964, ISBN = new Guid(), Author = "Ariel Naim", Name = "My First Book", NumberOfPages = 543, NumberOfCopies = 29, NumberOfBorrowedOut = 27, DatePublished = new DateTime(2007, 05, 24) });
            Books.Add(new Book { Id = 864, ISBN = new Guid(), Author = "Haim Mosh", Name = "Ein li Shem Amiti", NumberOfPages = 111, NumberOfCopies = 7, NumberOfBorrowedOut = 0, DatePublished = new DateTime(1985, 11, 11) });
            Books.Add(new Book { Id = 653, ISBN = new Guid(), Author = "Gady Halper", Name = "My New Car", NumberOfPages = 444, NumberOfCopies = 17, NumberOfBorrowedOut = 13, DatePublished = new DateTime(2021, 10, 21) });

        }

        public static void SaveBooks()
        {
            var s = "";
            foreach (var book in Library.Books)
            {
                s += book.ToCSV() + Environment.NewLine;

            }
            File.WriteAllText(@"C:\Users\user\Desktop\softwaredev\Projects Folder\HackerUs DigitalLibary\LibraryInfo.txt", s);
        }
    }
}
