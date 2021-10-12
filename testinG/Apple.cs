using System;
using System.Collections.Generic;
using System.Text;

namespace testinG
{
    class Apple:Pineapple
    {
        public Apple(int calo, double prot, double carb) : base(calo, prot, carb)
        {
            calories = calo;
            proteins = prot;
            carbs = carb;
        }
    }
}
