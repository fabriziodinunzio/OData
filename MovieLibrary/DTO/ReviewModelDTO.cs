using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.DTO
{
    public class ReviewModelDTO
    {
        public int Id { get; set; }
        public string Reviewer { get; set; }
        public string Summary { get; set; }
        public decimal Rating { get; set; }
        public string ReviewText { get; set; }
    }
}
