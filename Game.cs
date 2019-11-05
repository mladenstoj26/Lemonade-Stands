using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonadestand
{
    class Game
    {
        public Player player;
        public List<Day> Days;


        public Game()
        {
            Days = new List<Day>();
            CreateDays();
        }
        public void CreateDays()
        {
            for (int i = 0; i < 7; i++)
            {
                Day day = new Day(i + 1);
                Days.Add(day);

            }
        }
    }
}
    