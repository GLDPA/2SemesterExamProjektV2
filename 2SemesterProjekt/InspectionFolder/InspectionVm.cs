using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt.InspectionFolder
{
    class InspectionVm :TransformedWithDefaultBase<Inspection>
    {
        public bool IsClean { get; set; }
        public bool KeyIsReturned { get; set; }
        public bool SheetIsChanged { get; set; }
        public bool HouseIsNotDestroyed { get; set; }
        public string AllIsWell { get; set; }

        public override void SetValuesFromObject(Inspection obj)
        {
            Key = obj.Key;
            KeyIsReturned = obj.KeyIsReturned;
            IsClean = obj.IsClean;
            HouseIsNotDestroyed = obj.HouseIsNotDestroyed;
            SheetIsChanged = obj.SheetIsChanged;
            AllIsWell = obj.AllIsWell;
        }

        public override void SetDefaultValues()
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
