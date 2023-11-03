using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ChickenOrder
    {
        public int Quantity;


        public ChickenOrder(int quantityRequested)
        {
            Quantity = quantityRequested;
        }

        // constructor arqument is quantity requested  //
        public int GetQuantity()
        {
            return Quantity;  // returns same value as passed constructor//
        }
        public void CutUp()
        {
            for (int i = 0; i < Quantity; i++)
            {


            }// no arguments or return value 
            // should be called the number of times requested in quantity 
            Console.WriteLine($"CutUp the chicken {Quantity} ");
        }

        public void Cook()

        {
            Console.WriteLine();
            // no arguments or return value 
            // should be called once only 
        }

    }
}