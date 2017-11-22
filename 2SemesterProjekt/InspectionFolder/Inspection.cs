using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;
using InMemoryStorage.Implementation;

namespace _2SemesterProjekt.InspectionFolder
{
    class Inspection : TransformedBase<Inspection>
    {
        public bool IsClean { get; set; }
        public bool KeyIsReturned { get; set; }
        public bool SheetIsChanged { get; set; }
        public bool HouseIsNotDestroyed { get; set; }
        public string AllIsWell { get; set; }

        public override void SetValuesFromObject(Inspection obj)
        {
            Key = NullKey;
            IsClean = false;
            KeyIsReturned = false;
            HouseIsNotDestroyed = false;
            SheetIsChanged = false;
            AllIsWell = "(All Is Well)";
        }
    }
}
