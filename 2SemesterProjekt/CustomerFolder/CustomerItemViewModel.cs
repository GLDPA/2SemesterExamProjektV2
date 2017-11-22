using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt
{
    public class CustomerItemViewModel : DataWrapper<CustomerViewModel>
    {
        public CustomerItemViewModel(CustomerViewModel obj) : base(obj)
        {
        }
    }
}
