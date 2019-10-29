using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.DTO
{
    [DataContract(Name = "Review")]
    public class ReviewModelDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Reviewer { get; set; }
        [DataMember]
        public string Summary { get; set; }
        [DataMember]
        public decimal Rating { get; set; }
        [DataMember]
        public string ReviewText { get; set; }
    }
}
