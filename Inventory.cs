﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonadestand
{
    class Inventory
    {
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
    }
    public Inventory()
    {
        lemons = new List<Lemon>();
        sugarCubes = new List<SugarCube>();
        iceCubes = new List<IceCube>();
        cups = new List<Cup>();
    }
    public void AddLemonsToInventory(int numberOfLemons)
    {
        for (int i = 0; i < numberOfLemons; i++)
        {
            Lemon lemon = new Lemon();
            lemons.Add(lemon);  
        }
    public void AddSugarCubesToInventory(int numberOfSugarCubes)
    {
            for (int i = 0; i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
            }

    }
    public void AddIceCUbesToInventory(int numberOfIceCubes)
        {
            for (int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }
    public void AddCupsToInventory (int numberOfCups)
        {
            for (int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }
}
