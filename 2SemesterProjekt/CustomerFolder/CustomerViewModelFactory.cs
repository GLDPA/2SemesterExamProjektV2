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
        public override Customer CreateDomainObject(CustomerViewModel vmObj)
        {
            Customer customer = new Customer

            {
                Key = vmObj.Key,
                Name = vmObj.Name,
                Age = vmObj.Age,
                Email = vmObj.Email,
                PhoneNumber = vmObj.PhoneNumber,
                CardNumber = vmObj.CardNumber,
                CVRNumber = vmObj.CVRNumber,
                ExpirationYear = vmObj.ExpirationYear,
                ExpirationMonth = vmObj.ExpirationMonth
            };
            

            return customer;
        }
    }
}
