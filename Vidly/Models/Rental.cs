using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public DateTime RentalDate { get; set; }

        public  DateTime? ReturnDate { get; set; }
    }
}