using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.BookingFolder;


namespace _2SemesterProjekt
{
    class ObjectProvider
    {
        public static SummerHouseCatalog SummerHouseCatalog
        {
            get { return SummerHouseCatalog.Instance;}
        }

        public static CustomerCatalog CustomerCatalog
        {
            get { return CustomerCatalog.Instance;}
        }

        public static BookingCatalog BookingCatalog
        {
            get { return  BookingCatalog.Instance;}
        }
    }
}
