using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{

    [DataContract(Name ="Movie", Namespace ="http://myprojects/OData")]
    public class MovieModel
    {
        [DataMember]
        public virtual int Id { get; set; }
        [DataMember]
        public virtual string Title { get; set; }
        [DataMember]
        public virtual DateTime ReleaseDate { get; set; }
        [DataMember]
        public virtual ICollection<ReviewModel> Reviews { get; set; }
    }
}
