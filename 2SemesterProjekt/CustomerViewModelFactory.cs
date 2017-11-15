using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt
{
   public class CustomerViewModelFactory : FactoryBase<Customer, CustomerViewModel>
    {
        public override Customer CreateDomainObject(CustomerViewModel tObj)
        {
            throw new NotImplementedException();
        }
    }
}
