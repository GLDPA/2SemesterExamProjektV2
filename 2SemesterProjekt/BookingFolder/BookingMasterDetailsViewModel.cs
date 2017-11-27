using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ExtensionsViewModel.Implementation;

namespace _2SemesterProjekt.BookingFolder
{
    class BookingMasterDetailsViewModel : MasterDetailsViewModelCRUD<Booking, BookingVm, Booking>
    {
        public BookingMasterDetailsViewModel()
            : base(new BookingVmFactory(), ObjectProvider.BookingCatalog,
                new List<string> { }, new List<string>())
        { }

    }
}
