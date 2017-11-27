using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt.Faktura
{
    class FakturaItemVM : DataWrapper<FakturaVM>
    {
        public FakturaItemVM(FakturaVM obj) 
            : base(obj)
        {
        }
        public int Desciption { get { return DataObject.BookingID; } }
    }
}
