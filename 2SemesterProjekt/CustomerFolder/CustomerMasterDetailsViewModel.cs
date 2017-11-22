using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog.Implementation;
using ExtensionsViewModel.Implementation;
using ViewModel.Interfaces;
using _2SemesterProjekt.CustomerFolder;
using _2SemesterProjekt.SummerHouseMappe;

namespace _2SemesterProjekt
{
    public class CustomerMasterDetailsViewModel : MasterDetailsViewModelCRUD<Customer,CustomerViewModel,Customer>
    {
        public CustomerMasterDetailsViewModel()
            : base(new CustomerVMFactory(),
                ObjectProvider.CustomerCatalog,
                new List<string>{},
                new List<string>{})
        {
            CreateCustomer = new CustomerCreateCommands();
        }
        public CustomerCreateCommands CreateCustomer { get; set; }
    }
}
