using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    // , Namespace = "http://myprojects"
    [DataContract(Name = "Review")]
    public class ReviewModel
    {
        
        public virtual int Id { get; set; }
        
        public virtual string Reviewer { get; set; }
        
        public virtual string Summary { get; set; }
        
        public virtual decimal Rating { get; set; }
        
        public virtual string ReviewText { get; set; }
        
        public virtual MovieModel Movie { get; set; }
    }
}
