using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt.Faktura
{
    public class FakturaVM : TransformedBase<Faktura>
    {
        public int BookingID { get; set; }
        public int Price { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public int PhoneNr { get; set; }
        public int CardNr { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public int CVC { get; set; }

        public override void SetValuesFromObject(Faktura obj)
        {
            Key = obj.Key;
            BookingID = obj.BookingID;
            Price = obj.Price;
            CustomerName = obj.CustomerName;
            Email = obj.Email;
            PhoneNr = obj.PhoneNr;
            CardNr = obj.CardNr;
            ExpMonth = obj.ExpMonth;
            ExpYear = obj.ExpYear;
            CVC = obj.CVC;
        }
        //public override void SetDefaultValues()
        //{
        //    Key = NullKey;
        //    BookingID = 123;
        //    CustomerName = "(CustomerName)";
        //    Email = "(Email)";
        //    PhoneNr = 12346578;
        //    CardNr = 16;
        //    ExpMonth = 02;
        //    ExpYear = 21;
        //    CVC = 456;
        }
    }


