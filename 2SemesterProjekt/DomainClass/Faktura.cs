using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using InMemoryStorage.Implementation;

namespace _2SemesterProjekt.Faktura
{
    public class Faktura : StorableBase, ITransformed<Faktura>
    {
        public Faktura(int bookingID, int price, string customerName, string email, int phoneNr, int cardNr, int expMonth, int expYear, int cVC)
        {
            BookingID = bookingID;
            Price = price;
            CustomerName = customerName;
            Email = email;
            PhoneNr = phoneNr;
            CardNr = cardNr;
            ExpMonth = expMonth;
            ExpYear = expYear;
            CVC = cVC;
        }

        public Faktura()
        {
            throw new NotImplementedException();
        }


        public int BookingID { get; set; }
        public int Price { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public int PhoneNr { get; set; }
        public int CardNr { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public int CVC { get; set; }

        public ITransformed<Faktura> Clone()
        {
            throw new NotImplementedException();
        }

        public void SetValuesFromObject(Faktura obj)
        {
            throw new NotImplementedException();
        }
    }
}
