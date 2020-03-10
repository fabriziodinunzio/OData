using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCL
{
    public class Institution
    {
        public long InstitutionId { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
    }

    public class Course
    {
        public long CourseId { get; set; }
        public long InstitutionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
