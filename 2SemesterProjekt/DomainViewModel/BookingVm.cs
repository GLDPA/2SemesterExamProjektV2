using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt.BookingFolder
{
 public  class BookingVm : TransformedBase<Booking>
    {

        public string Name { get; }

        public int Price { get; }

        public string Email { get; }

        public int PhoneNumber { get; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int NumberOfChildren { get; set; }

        public int NumberOfAnimals { get; set; }

        public override void SetValuesFromObject(Booking obj)
        {
            Key = obj.Key;
            StartDate = obj.StartDate;
            EndDate = obj.EndDate;
            NumberOfChildren = obj.NumberOfChildren;
            NumberOfAnimals = obj.NumberOfAnimals;

        }
    }
}
