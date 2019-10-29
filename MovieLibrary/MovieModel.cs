using MovieLibrary.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    // , Namespace ="http://myprojects/OData"
    
    public class MovieModel
    {
        
        public virtual int Id { get; set; }
        
        public virtual string Title { get; set; }
        
        public virtual DateTime ReleaseDate { get; set; }
        
        public virtual ICollection<ReviewModel> Reviews { get; set; }
    }
}
