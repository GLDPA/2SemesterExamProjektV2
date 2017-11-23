using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace _2SemesterProjekt.BookingFolder
{
    class BookingDetailsViewModel : DetailsViewModelBase<BookingVm>
    {
        public BookingDetailsViewModel(BookingVm obj) : base(obj)
        {
        }

        public DateTime StartDateTime
        {
            get { return DataObject.StartDate; } set { DataObject.StartDate = value; OnPropertyChanged(); }

        }

        public DateTime EndDateTime
        {
            get { return DataObject.EndDate; } set { DataObject.EndDate = value; OnPropertyChanged(); }
        }


        public int NumberOfChilren
        {
            get { return DataObject.NumberOfChildren; } set { DataObject.NumberOfChildren = value; OnPropertyChanged(); }


        }


        public int NumberOfAnimals
        {
            get { return DataObject.NumberOfAnimals; } set { DataObject.NumberOfAnimals = value; OnPropertyChanged(); }
        }



    }
}
