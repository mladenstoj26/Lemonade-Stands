﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonadestand
{
    class Wallet
    {
        private double money;
        public double Money
        {
            get
            {
                return money;
            }
        }
        public Wallet()
        {
            money = 20.00
        }

        public void PayMoneyForItems(double transactionAmount)
        {
            money -= transactionAmount;
        }
    }
}
 
