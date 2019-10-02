using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    //// Film
    [DataContract(Name = "Movie", Namespace = "http://myprojects/oData")]
    public class MovieModel
    {
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        [DataMember]
        [Required]
        public virtual string Title { get; set; }

        [DataMember]
        public virtual DateTime ReleaseDate { get; set; }
        [DataMember]
        public virtual ICollection<ReviewModel> Reviews { get; set; }
    }
}
