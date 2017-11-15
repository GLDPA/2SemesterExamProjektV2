using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt
{
    public class CustomerViewModel : TransformedBase<Customer>
    {
        public override void SetValuesFromObject(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
