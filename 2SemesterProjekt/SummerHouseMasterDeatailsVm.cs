using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog.Implementation;
using ExtensionsViewModel.Implementation;
using ViewModel.Interfaces;

namespace _2SemesterProjekt
{
    class SummerHouseMasterDeatailsVm: MasterDetailsViewModelCRUD<SummerHouse,SommerhusVm,SummerHouse>
    {
        public SummerHouseMasterDeatailsVm(IViewModelFactory<SommerhusVm> viewModelFactory, PersistableCatalog<SummerHouse, SommerhusVm, SummerHouse> catalog, List<string> immutableControls, List<string> mutableControls) : base(viewModelFactory, catalog, immutableControls, mutableControls)
        {
        }
    }
}
