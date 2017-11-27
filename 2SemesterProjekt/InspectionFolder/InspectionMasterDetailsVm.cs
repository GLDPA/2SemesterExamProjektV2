using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionsViewModel.Implementation;

namespace _2SemesterProjekt.InspectionFolder
{
    class InspectionMasterDetailsVm : MasterDetailsViewModelCRUD<Inspection, InspectionVm, Inspection>
    {
        public InspectionMasterDetailsVm()
            : base(new InspectionVmFactory(),
                ObjectProvider.InspectionCatalog,
                new List<string> {"AllIsWell"},
                new List<string> {"HouseIsNotDestroyed"})
        {
        }
    }
}
