using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using ViewModel.Implementation;

namespace _2SemesterProjekt.Faktura
{
    class FakturaVmFactory2 : ViewModelFactoryBase<Faktura,FakturaVM>
    {
        public override IDataWrapper<FakturaVM> CreateDetailsViewModel(FakturaVM obj)
        {
            return new FakturaDetailsVM(obj);
        }

        public override IDataWrapper<FakturaVM> CreateItemViewModel(FakturaVM obj)
        {
            return new FakturaDetailsVM(obj);
        }
    }
}
