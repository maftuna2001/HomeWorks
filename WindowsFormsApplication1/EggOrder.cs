using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class EggOrder



    {
        public int Quantity;


        public int? Quality;
        static int counter = 0;
        public object p;

        public EggOrder(int quantityRequested)
        {
            Quantity = quantityRequested;

            Random random = new Random();
            Quality = random.Next(1, 101);

        }

        public EggOrder(object p)
        {
            this.p = p;
        }

        /* constructor argument is quantity requested */







        public int GetQuantity()
        {
            return Quantity;/* returns some value as passed constructor*/
        }


        public int? GetQuality()
        {
            counter++;
            if (counter % 2 == 0)
            {

                return null;
            }
            else
            {

                return Quality;

            }

        }


        /*1quality is A random numeric between 1 and 100 calculated once per instance of the class 
       //    2the method should return a nullable value type 
       //    3to simulate the employee forgetting 1/2 of the time the method should returna null value on the 2 nd 4th 6th etc instance of the class*/



        public void Crack() /* these 3 methods dont have arguments and dont return value 
            
            crack method should throw an exception if the egg quality is less than 25 / this simulates a rotten egg 
             надо использовать try catch finally method */
        {

            try
            {


                if (Quality < 25)
                {
                    throw new InvalidOperationException("Rotten egg, can't crack.");
                }

                Discardshell();

            }
            catch (InvalidOperationException ex)
            {
                // Handle the exception if quality is lower than 25
                throw new InvalidOperationException("Rotten egg, can't crack.");
            }

        }

        public void Discardshell()
        {
            Console.WriteLine("Discarding the eggshell");
        }


        public string Cook()
        {
            return "Cooking";
        }

    }
}