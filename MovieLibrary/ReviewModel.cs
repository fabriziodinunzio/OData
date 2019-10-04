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
        [DataMember]
        public virtual int Id { get; set; }
        [DataMember]
        public virtual string Reviewer { get; set; }
        [DataMember]
        public virtual string Summary { get; set; }
        [DataMember]
        public virtual decimal Rating { get; set; }
        [DataMember]
        public virtual string ReviewText { get; set; }
        [DataMember]
        public virtual MovieModel Movie { get; set; }
    }
}
