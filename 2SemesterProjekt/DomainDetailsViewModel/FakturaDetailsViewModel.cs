using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace _2SemesterProjekt.Faktura
{
    class FakturaDetailsVM : DetailsViewModelBase<FakturaVM>
    {
        public FakturaDetailsVM(FakturaVM obj)
            : base(obj)
        {
        }

        public int BookingId
        {
            get { return DataObject.BookingID; }
            set
            {
                DataObject.BookingID = value;
                OnPropertyChanged();
            }
        }

        public int Price
        {
            get { return DataObject.Price; }
            set
            {
                DataObject.Price = value;
                OnPropertyChanged();
            }
        }

        public string CustomerName
        {
            get { return DataObject.CustomerName; }
            set
            {
                DataObject.CustomerName = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get { return DataObject.Email; }
            set
            {
                DataObject.Email = value;
                OnPropertyChanged();
            }
        }
        public int PhoneNr
        {
            get { return DataObject.PhoneNr; }
            set
            {
                DataObject.PhoneNr = value;
                OnPropertyChanged();
            }
        }
        public int CardNr
        {
            get { return DataObject.CardNr; }
            set
            {
                DataObject.CardNr = value;
                OnPropertyChanged();
            }
        }
        public int ExpMonth
        {
            get { return DataObject.ExpMonth; }
            set
            {
                DataObject.ExpMonth = value;
                OnPropertyChanged();
            }
        }
        public int ExpYear
        {
            get { return DataObject.ExpYear; }
            set
            {
                DataObject.ExpYear = value;
                OnPropertyChanged();
            }
        }
        public int CVC
        {
            get { return DataObject.CVC; }
            set
            {
                DataObject.CVC = value;
                OnPropertyChanged();
            }
        }
    }
}
