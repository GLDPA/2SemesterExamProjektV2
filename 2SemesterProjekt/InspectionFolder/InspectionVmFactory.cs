using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using ViewModel.Implementation;

namespace _2SemesterProjekt.InspectionFolder
{
    class InspectionVmFactory : ViewModelFactoryBase<Inspection, InspectionVm>
    {
        public override IDataWrapper<InspectionVm> CreateDetailsViewModel(InspectionVm obj)
        {
            return new InspectionDetailsVm(obj);
        }

        public override IDataWrapper<InspectionVm> CreateItemViewModel(InspectionVm obj)
        {
            return new InspectionItemVm(obj);
        }
    }
}
