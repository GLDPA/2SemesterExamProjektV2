using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog.Implementation;
using ExtensionsViewModel.Implementation;
using ViewModel.Interfaces;
using _2SemesterProjekt.SummerHouseMappe;

namespace _2SemesterProjekt
{
    class SummerHouseMasterDeatailsVm : MasterDetailsViewModelCRUD<SummerHouse, SommerhusVm, SummerHouse>
    {
        public SummerHouseMasterDeatailsVm()
            : base(new SummerhouseVmFactory2(),
                ObjectProvider.SummerHouseCatalog,
                new List<string>{"StreetNr"},
                new List<string>{"ZipCóde"})

         {
         ToSummerHouse = new NavigatetoSummerHouseGUI();
         }
      
        public NavigatetoSummerHouseGUI ToSummerHouse { get; set; }
    }
}