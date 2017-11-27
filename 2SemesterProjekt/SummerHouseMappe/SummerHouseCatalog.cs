using ExtensionsModel.Implementation;

namespace _2SemesterProjekt
{
    class SummerHouseCatalog : FilePersistableCatalogNoDTO<SummerHouse, SommerhusVm>
    {
        private static SummerHouseCatalog instance;
        public static SummerHouseCatalog Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SummerHouseCatalog();
                }
                return instance;
            }
        }

        public SummerHouseCatalog() : base(new SummerHouseVmFactory1())
        {
        }
    }
}
