using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;
using DataTransformation.Interfaces;
using InMemoryStorage.Implementation;

namespace _2SemesterProjekt 
{
    public class SummerHouse : TransformedBase<SummerHouse>
    {
        public string StreetName { get; set; }
        public string StreetNr { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Municipality { get; set; }
        public string NickName { get; set; }


        public override void SetValuesFromObject(SummerHouse obj)
        {
            StreetName = obj.StreetName;
            StreetNr = obj.StreetNr;
            ZipCode = obj.ZipCode;
            City = obj.City;
            Municipality = obj.Municipality;
            NickName = obj.NickName;
        }
    }
}
