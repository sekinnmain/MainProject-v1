using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
//using PLplot;
using System.Diagnostics;

namespace Main.yonor
{

    public class StockManagement
    {
     
        //Here we can lock it to be threat safe! to discuss with the team.
        public StockManagement(){ }
        public int burgetStock { get; set; }
        public int steakStock { get; set; }
        public int pulletStock { get; set; }
        public int sodaStock { get; set; }
        public int waterStock { get; set; }
        public int colaStock { get; set; }

        public int remainingDishes()
        {
            return (burgetStock + steakStock + pulletStock + sodaStock + waterStock + colaStock);
        }


    }

}