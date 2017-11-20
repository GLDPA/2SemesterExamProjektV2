using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store.Preview.InstallControl;
using Windows.Graphics.Printing;
using Catalog.Implementation;
using DataTransformation.Interfaces;
using ExtensionsModel.Implementation;
using InMemoryStorage.Interfaces;

namespace _2SemesterProjekt
{
   public class CustomerCatalog : FilePersistableCatalogNoDTO<Customer, CustomerViewModel>, IStorable
   {
       private static CustomerCatalog _instance;
       
       public CustomerCatalog() : base(new CustomerViewModelFactory())
       {
       }

       public static CustomerCatalog Instance
       {
           get
            {
               if (_instance == null)
               {
                   _instance = new CustomerCatalog();
               }
               return _instance;
           } 
       }
   }

    
}
