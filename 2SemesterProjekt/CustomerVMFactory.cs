﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using ViewModel.Implementation;

namespace _2SemesterProjekt
{
    class CustomerVMFactory : ViewModelFactoryBase<Customer, CustomerViewModel>
    {
        public override IDataWrapper<CustomerViewModel> CreateDetailsViewModel(CustomerViewModel obj)
        {
            throw new NotImplementedException();
        }

        public override IDataWrapper<CustomerViewModel> CreateItemViewModel(CustomerViewModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
