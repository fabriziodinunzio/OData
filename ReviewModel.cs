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
    [DataContract(Name = "Review", Namespace = "http://myprojects/oData")]
    public class ReviewModel
    {
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        [DataMember]
        public virtual string Summary { get; set; }
        [DataMember]
        [Required]
        public virtual string Reviewer { get; set; }
        [DataMember]
        public virtual string ReviewText { get; set; }
        [DataMember]
        public virtual MovieModel Movie { get; set; }
    }
}
