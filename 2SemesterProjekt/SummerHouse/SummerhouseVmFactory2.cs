using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using ViewModel.Implementation;

namespace _2SemesterProjekt
{
    class SummerhouseVmFactory2 : ViewModelFactoryBase<SummerHouse, SommerhusVm>
    {
        public override IDataWrapper<SommerhusVm> CreateDetailsViewModel(SommerhusVm obj)
        {
            return new SummerHouseDeatailsVm(obj);
        }

        public override IDataWrapper<SommerhusVm> CreateItemViewModel(SommerhusVm obj)
        {
            return new SummerHouseItemVm(obj);
        }
    }
}
