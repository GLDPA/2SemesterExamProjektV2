using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using ExtensionsModel.Implementation;

namespace _2SemesterProjekt.Faktura
{
    public class FakturaCatalog : FilePersistableCatalogNoDTO<Faktura, FakturaVM>
    {
        public FakturaCatalog(IFactory<Faktura, FakturaVM> vmFactory) : base(vmFactory)
        {
        }
    }
}
