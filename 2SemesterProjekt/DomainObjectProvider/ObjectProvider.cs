using _2SemesterProjekt.Faktura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.BookingFolder;
using _2SemesterProjekt.InspectionFolder;


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
            get { return BookingCatalog.Instance; }
        }
        public static FakturaCatalog FakturaCatalog
        {
            get { return FakturaCatalog.Instance; }
        }
        public static InspectionCatalog InspectionCatalog
        {
            get { return InspectionCatalog.Instance; }
        }
    }
}
