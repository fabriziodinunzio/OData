using EntitiesCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciesCL
{
    public class InstitutionService : IInstiutionService
    {
        public Institution GetInstitutionById(long institutionId)
        {
            return new Institution()
            {
                InstitutionId = institutionId
                ,
                Address = "Demo Address"
                ,
                Name = "Demo Name"
                ,
                Telephone = "349-8406072"
            };
                
        }
    }

    public class CourseService : ICourseService
    {
        public Course GetCourseById(long courseId)
        {
            return new Course()
            {
                CourseId = courseId
                ,
                InstitutionId = 1
                ,
                Description = "Demo course description"
                ,
                Title = "Demo course title"

            };
        }
    }
}
