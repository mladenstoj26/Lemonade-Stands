using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonadestand
{
    class Day
    {
        // member variables(HAS A)
        public Weather weather;
        public List<Customer> customers;
        public int DayNumber;
        public Day(int daynumber)
        {
            weather = new Weather();
            DayNumber = daynumber;

            ///build customers

        }

         public void RunDay()
         {
              weather.CreateCondition();
              weather.CreateTemperature();
              
         }
      

        //method for building customers

    }
}
