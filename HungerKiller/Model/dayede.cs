﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerKiller.Model
{
    class dayede
    {
        private static dayede instance;
        private static List<hehehhe> Dish = null;
        private dayede()
        {

        }

        public static dayede getinstance()
        {
            if (instance == null)
            {
                instance = new dayede();
            }
            return instance;

        }
        public List<hehehhe> getDish()
        {
            if (Dish == null)
            {
                Dish = new List<hehehhe>();
            }
            return Dish;
        }
    }
}
