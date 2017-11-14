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
    class CustomerMasterDetailsViewModel : MasterDetailsViewModelCRUD<Customer, CustomerViewModel, Customer>
    {
        public CustomerMasterDetailsViewModel(IViewModelFactory<CustomerViewModel> viewModelFactory, PersistableCatalog<Customer, CustomerViewModel, Customer> catalog, List<string> immutableControls, List<string> mutableControls) 
            : base(viewModelFactory, catalog, immutableControls, mutableControls)
        {
        }
    }
}
