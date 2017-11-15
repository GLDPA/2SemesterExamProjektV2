﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using ViewModel.Implementation;

namespace _2SemesterProjekt
{
    class SummerhouseVmFactory : ViewModelFactoryBase<Sommerhus, SommerhusVm>
    {
        public override IDataWrapper<SommerhusVm> CreateDetailsViewModel(SommerhusVm obj)
        {
            throw new NotImplementedException();
        }

        public override IDataWrapper<SommerhusVm> CreateItemViewModel(SommerhusVm obj)
        {
            throw new NotImplementedException();
        }
    }
}
