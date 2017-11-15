using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace _2SemesterProjekt
{
    class CustomerDetailsViewModel : DetailsViewModelBase<CustomerViewModel>
    {
        public CustomerDetailsViewModel(CustomerViewModel obj) : base(obj)
        {
        }
    }
}
