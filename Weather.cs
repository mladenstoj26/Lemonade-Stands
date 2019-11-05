using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonadestand
{
    class Weather
    {
        public string condition;
        public int temperature;
        List<string>weatherConditions = new List<string>
        {
            "Cloudy",
            "Sunny",
            "Rainy"
        };
        Random rnd = new Random();
        public void CreateCondition()
        {
            Random rand = new Random();
            int result = rnd.Next(3);
          
            string condition = weatherConditions[result];
        }
        public void CreateTemperature()
        {
            Random rand = new Random();
             int temperature = rnd.Next(50, 100);
            
        }

        public void DisplayWeather()
        {
            
            string weatherForecast = "Today is" + condition + temperature;
            Console.WriteLine(weatherForecast);
        }
      
    
    }
}

public void ------_------_-------(){}
                    //Ex public void SetCondition_ZeroIndex_ConditionSetToSunny()
          
		//arange
		            ___ ____ = new _____();
string/bool/int expected = _____;
string/bool/int actual;

//act
____.________();
                    //ex weather.SetCondition()
                    actual = ____._______;
                    //ex actual = weather.condition;
        //assert
                    Assert.AreEqual(expected, actual);

        //TestALL
