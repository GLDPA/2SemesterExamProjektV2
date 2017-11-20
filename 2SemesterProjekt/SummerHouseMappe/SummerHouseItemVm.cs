using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;
using _2SemesterProjekt.SummerHouseMappe;

namespace _2SemesterProjekt
{
    class SummerHouseItemVm: DataWrapper<SommerhusVm>
    {
        public SummerHouseItemVm(SommerhusVm obj) 
            : base(obj)
        {
            ToSummerHouse = new NavigatetoSummerHouseGUI();
        }
        public NavigatetoSummerHouseGUI ToSummerHouse { get; set; }


        public string Description
        {
            get { return DataObject.StreetName; }
        }
    }
}
