using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt
{
    class SummerHouseItemVm: DataWrapper<SommerhusVm>
    {
        public SummerHouseItemVm(SommerhusVm obj) 
            : base(obj)
        {
        }

        public string Description
        {
            get { return DataObject.StreetName; }
        }

    }
}
