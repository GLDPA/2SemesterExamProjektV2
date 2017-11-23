using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionsViewModel.Implementation;

namespace _2SemesterProjekt.InspectionFolder
{
   public class InspectionMasterDetailsVm : MasterDetailsViewModelCRUD<Inspection, InspectionVm, Inspection>
    {
        public InspectionMasterDetailsVm()
            : base(new InspectionVmFactory1(),
                ObjectProvider.InspectionCatalog,
                new List<string> {"AllIsWell"},
                new List<string> {"HouseIsNotDestroyed"})
        {
        }
    }
}
