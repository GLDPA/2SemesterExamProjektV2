using ExtensionsViewModel.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Faktura
{
    public class MasterDetailsViewModel
   : MasterDetailsViewModelCRUD<Faktura, FakturaVM, Faktura>
    {
        public MasterDetailsViewModel()
           : base(new FakturaVmFactory2(),
                  ObjectProvider.FakturaCatalog,
                  new List<string> { "Title", "Year", "StudioId" },
                  new List<string> { "Mins" })
        {

        }            
 

    }
}
