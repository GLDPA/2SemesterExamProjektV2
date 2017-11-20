using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt
{
    class SummerHouseVmFactory1 :FactoryBase<SummerHouse, SommerhusVm>
    {
        public override SummerHouse CreateDomainObject(SommerhusVm vmObj)
        {
            SummerHouse obj = new SummerHouse
            {
                Key = vmObj.Key,
                StreetNr = vmObj.StreetNr,
                StreetName = vmObj.StreetName,
                City = vmObj.City,
                ZipCode = vmObj.ZipCode,
                Municipality = vmObj.Municipality,
                NickName = vmObj.NickName
            };
        return obj;
        }
    }
}
