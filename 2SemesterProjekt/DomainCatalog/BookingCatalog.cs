using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using ExtensionsModel.Implementation;

namespace _2SemesterProjekt.BookingFolder
{
   public class BookingCatalog : FilePersistableCatalogNoDTO<Booking, BookingVm>
    {
        private static BookingCatalog _instance;
        public static BookingCatalog Instance
        {
            get
            {
                if (_instance == null)
                {
                   _instance = new BookingCatalog();
                }
                return _instance;
            }
        }
        //public BookingCatalog: base(new  BookingViewModelFactory())
        //{
        //}
        public BookingCatalog() : base(new BookingViewModelFactory())
        {
        }
    }
}
