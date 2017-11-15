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
    class SummerHouseCatalog:Catalog<Sommerhus,SommerhusVm,SommerhusVmFactory>
    {
        public SummerHouseCatalog(IInMemoryCollection<Sommerhus> collection, IPersistentSource<SommerhusVmFactory> source, IFactory<Sommerhus, SommerhusVm> vmoFactory, IFactory<Sommerhus, SommerhusVmFactory> dtoFactory, List<PersistencyOperations> supportedOperations) : base(collection, source, vmoFactory, dtoFactory, supportedOperations)
        {
        }
    }
}
