using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.DTO
{
    [DataContract(Name = "Movie")]
    public class MovieModelDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Il titolo del film non può essere vuoto")]
        public string Title { get; set; }
        [DataMember]
        public DateTime ReleaseDate { get; set; }
    }
}
