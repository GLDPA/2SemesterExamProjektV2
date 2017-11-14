using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog.Implementation;
using DataTransformation.Interfaces;
using ExtensionsModel.Implementation;

namespace _2SemesterProjekt
{
   public class CustomerCatalog : FilePersistableCatalogNoDTO<Customer, CustomerViewModel>
   {
       public CustomerCatalog(IFactory<Customer, CustomerViewModel> vmFactory) : base(vmFactory)
       {
       }
   }
}
