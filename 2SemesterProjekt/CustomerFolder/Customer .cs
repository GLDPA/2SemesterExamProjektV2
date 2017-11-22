using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using InMemoryStorage.Interfaces;

namespace _2SemesterProjekt
{
   public class Customer : IStorable, ITransformed<Customer>
   {

       public string Name { get; set; }
       public int Age { get; set; }
       public string Email { get; set; }
       public int PhoneNumber { get; set; }
       public int CardNumber { get; set; }
       public int CVRNumber { get; set; }
       public int ExpirationMonth { get; set; }
       public int ExpirationYear { get; set; }

       
        public int Key { get; set; }
       public ITransformed<Customer> Clone()
       {
           throw new NotImplementedException();
       }

       public void SetValuesFromObject(Customer obj)
       {
           throw new NotImplementedException();
       }


       
   }
}
