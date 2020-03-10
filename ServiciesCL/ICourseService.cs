using EntitiesCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciesCL
{
    public interface ICourseService
    {
        Course GetCourseById(long courseId);
    }
}
