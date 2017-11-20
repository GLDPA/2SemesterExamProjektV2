using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.SummerHouseMappe;

namespace _2SemesterProjekt
{
    class MainPageVM
    {
        public MainPageVM()
        {
            
        }

        public NavigateToSummerHouseView ToSummerHouseView
        {
            get { return new NavigateToSummerHouseView(); }
        }
    }
}
