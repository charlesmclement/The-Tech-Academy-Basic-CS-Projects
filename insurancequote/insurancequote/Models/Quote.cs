using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace insurancequote.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int CarYear { get; set; }
        public int Tickets { get; set; }
        public bool FullCoverage { get; set; }
        public bool Dui { get; set; }
        public DateTime QuoteDate { get; set; }
        public decimal QuoteAmount { get; set; }

    }
}