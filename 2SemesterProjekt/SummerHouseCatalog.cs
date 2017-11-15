using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog.Implementation;
using DataTransformation.Interfaces;
using InMemoryStorage.Interfaces;
using Persistency.Interfaces;

namespace _2SemesterProjekt
{
    class SummerHouseCatalog:Catalog<SummerHouse,SommerhusVm,SummerHouseVmFactory1>
    {
        public SummerHouseCatalog(IInMemoryCollection<SummerHouse> collection, IPersistentSource<SummerHouseVmFactory1> source, IFactory<SummerHouse, SommerhusVm> vmoFactory, IFactory<SummerHouse, SummerHouseVmFactory1> dtoFactory, List<PersistencyOperations> supportedOperations) : base(collection, source, vmoFactory, dtoFactory, supportedOperations)
        {
        }
    }
}
