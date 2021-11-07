using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public Guid ISBN { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public int NumberOfPages { get; set; }
        public short NumberOfCopies { get; set; }
        public short NumberOfBorrowedOut { get; set; }
        public DateTime DatePublished { get; set; }


        public string ToCSV()
        {
            
            string str;
            str = string.Format("{0},{1},{2},{3},{4}", Id, ISBN, Author, Name, DatePublished);
            return str;
        }

        public bool IsNewBindingNeeded()
        {
            return DatePublished.Year < DateTime.Now.AddYears(20).Year;
        }

    }
}
