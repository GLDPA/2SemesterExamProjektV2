using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt.InspectionFolder
{
    class InspectionItemVm : DataWrapper<InspectionVm>
    {
        public InspectionItemVm(InspectionVm obj) 
            : base(obj)
        {
        }

        public string Description
        {
            get { return DataObject.AllIsWell; }
        }
    }
}
