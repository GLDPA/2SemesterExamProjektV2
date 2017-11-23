using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using ViewModel.Implementation;

namespace _2SemesterProjekt.BookingFolder
{
  public  class BookingVmFactory : ViewModelFactoryBase<Booking, BookingVm>
    {
        public override IDataWrapper<BookingVm> CreateDetailsViewModel(BookingVm obj)
        {
            return new BookingDetailsViewModel(obj);
        }

        public override IDataWrapper<BookingVm> CreateItemViewModel(BookingVm obj)
        {
           return new BookingItemVm(obj);
        }
    }
}
