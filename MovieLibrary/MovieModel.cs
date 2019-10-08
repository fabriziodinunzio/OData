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
    [DataContract(Name ="Movie")]
    public class MovieModel
    {
        [DataMember]
        public virtual int Id { get; set; }
        [DataMember]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Il titolo del film non può essere vuoto")]
        public virtual string Title { get; set; }
        [DataMember]
        public virtual DateTime ReleaseDate { get; set; }
        [DataMember]
        public virtual ICollection<ReviewModel> Reviews { get; set; }
    }
}
