using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using ExtensionsModel.Implementation;

namespace _2SemesterProjekt.InspectionFolder
{
    class InspectionCatalog :FilePersistableCatalogNoDTO<Inspection,InspectionVm>
    {
        private static InspectionCatalog instance;

        public static InspectionCatalog Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InspectionCatalog();
                }
                return instance;
            }
        }

        public InspectionCatalog() : base(new InspectionVmFactory1())
        {
        }
    }

}
