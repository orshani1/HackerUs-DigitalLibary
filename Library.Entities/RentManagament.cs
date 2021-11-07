using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class RentManagament
    {
        public DateTime BorowingDate { get; set; }
        public DateTime DueReturningDate => BorowingDate.AddDays(14);
        public DateTime ReturningDate { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int ClientId { get; set; }
        
        public Client Client { get; set; }
    }
}
