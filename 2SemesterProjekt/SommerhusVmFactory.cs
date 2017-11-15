using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt
{
    class SommerhusVmFactory :FactoryBase<Sommerhus, SommerhusVm>
    {
        public override Sommerhus CreateDomainObject(SommerhusVm tObj)
        {
            throw new NotImplementedException();
        }
    }
}
