using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt.InspectionFolder
{
    class InspectionVmFactory1 :FactoryBase<Inspection, InspectionVm>
    {
        public override Inspection CreateDomainObject(InspectionVm tObj)
        {
            Inspection obj = new Inspection
            {
               Key = tObj.Key,
               AllIsWell =  tObj.AllIsWell,
               SheetIsChanged = tObj.SheetIsChanged,
               IsClean = tObj.IsClean,
               HouseIsNotDestroyed = tObj.HouseIsNotDestroyed,
               KeyIsReturned = tObj.KeyIsReturned
            };
            return obj;
        }
    }
}
