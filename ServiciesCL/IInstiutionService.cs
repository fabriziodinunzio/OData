using EntitiesCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciesCL
{
    public interface IInstiutionService
    {
        Institution GetInstitutionById(long institutionId);
    }
}
