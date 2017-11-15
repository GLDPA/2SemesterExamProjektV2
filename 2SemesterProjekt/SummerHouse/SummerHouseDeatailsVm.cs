using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace _2SemesterProjekt
{
    class SummerHouseDeatailsVm : DetailsViewModelBase<SommerhusVm>
    {
        public SummerHouseDeatailsVm(SommerhusVm obj) 
            : base(obj)
        {
        }
        public string StreetName { get { return DataObject.StreetName; } set{ DataObject.StreetName = value; OnPropertyChanged();} }
        public string StreetNr { get { return DataObject.StreetNr; } set { DataObject.StreetNr=value; OnPropertyChanged(); } }
        public int ZipCode { get { return DataObject.ZipCode; } set { DataObject.ZipCode = value; OnPropertyChanged(); } }
        public string City { get { return DataObject.City; } set { DataObject.City = value; OnPropertyChanged(); } }
        public string Municipality { get { return DataObject.Municipality; } set { DataObject.Municipality = value; OnPropertyChanged(); } }
        public string NickName { get { return DataObject.NickName; } set { DataObject.NickName = value; OnPropertyChanged(); } }
    }
}
