using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;
using DataTransformation.Interfaces;

namespace _2SemesterProjekt.BookingFolder
{
    class BookingItemVm : DataWrapper<BookingVm>
    {
        public BookingItemVm(BookingVm obj) : base(obj)
        {
        }


        public string Name { get { return DataObject.Name; } }

        public int Price { get { return DataObject.Price; } }

        public string Email { get { return DataObject.Email; } }

        public int PhoneNumber { get { return DataObject.PhoneNumber; } }

        public DateTime StartDateTime { get { return DataObject.StartDate; } }

        public DateTime EndDateTime { get { return DataObject.EndDate; } }

        public  int NumberOfChildren { get { return DataObject.NumberOfChildren; } }

        public  int NumberOfAnimals { get { return DataObject.NumberOfAnimals; }}
    }
}
