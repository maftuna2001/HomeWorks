using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Employee
    {
        private bool isFoodPrepared = false;
        static object lastRequest;
        static int orderCount = 0;
        public Employee()
        // constructor with no arguments 
        {
            lastRequest = null;
        }


        public object NewRequest(int quantity, object menuitem)//new method with quantity and menu item argument , return object ( either chickenOrder
                                                               //or EggOrder  class
        {

            orderCount++;
            if (menuitem is ChickenOrder)

            {
                if (orderCount % 3 == 0)
                {
                    lastRequest = new EggOrder(quantity);
                }
                else
                {
                    lastRequest = new ChickenOrder(quantity);
                }
            }

            else if (menuitem is EggOrder)

            {
                if (orderCount % 3 == 0)
                {
                    lastRequest = new ChickenOrder(quantity);
                }
                else
                {
                    lastRequest = new EggOrder(quantity);
                }

            }
            else
            {
                throw new ArgumentException("invalid item");
            }
            return lastRequest;
        }

        public object CopyRequest()  // no arguments
        {


            if (lastRequest == null)
            {
                throw new Exception("No Orders!");
            }

            object copiedRequest = null;

            if (lastRequest is ChickenOrder)
            {
                ChickenOrder lastChickenRequest = (ChickenOrder)lastRequest;
                copiedRequest = new ChickenOrder(lastChickenRequest.GetQuantity());
            }
            else if (lastRequest is EggOrder)
            {
                EggOrder lastEggRequest = (EggOrder)lastRequest;
                copiedRequest = new EggOrder(lastEggRequest.GetQuantity());
            }

            if (copiedRequest != null)
            {
                lastRequest = copiedRequest; // Update lastRequest with the copied instance
                return copiedRequest;
            }

            return null; // Return null if the copy operation fails

        }
        public string Inspect(object request)    // object argument as returned from newrequest or copyrequest methods 
        {

            if (request is EggOrder)
            {
                var egg = request as EggOrder;
                string eggstring = egg.GetQuality()?.ToString();
                if (eggstring != null)
                {
                    return eggstring;

                }
                else
                {
                    return "Oops, forgot Quality!";
                }
            }
            else if
                    (request is ChickenOrder)
            {
                return "No Inspection!";
            }
            else
            {
                return "else commited";
            }







            // return results of inspection (string)
        }

        public string PrepareFood(object request)  // object argument as returned from newrequest or copyrequest methods
        {
            try
            {
                if (isFoodPrepared)
                {
                    throw new InvalidOperationException("Food has already been prepared. Cannot prepare it again.");
                }


                if (request is ChickenOrder)
                {
                    var chicken = request as ChickenOrder;
                    new ChickenOrder(chicken.GetQuantity());
                    for (int i = 0; i < chicken.GetQuantity(); i++)
                    {
                        chicken.CutUp();
                    }
                    chicken.Cook();

                    isFoodPrepared = true;
                    return $"{chicken.GetQuantity()} Chicken has been prepared.";

                }
                else if (request is EggOrder)
                {
                    var egg = request as EggOrder;

                    for (int i = 0; i < egg.GetQuantity(); i++)
                    {
                        try
                        {
                            egg.Crack();
                        }
                        catch (Exception ex)
                        {
                            throw new InvalidOperationException(ex.Message);
                        }
                        finally
                        {
                            egg.Discardshell();
                        }

                    }
                    egg.Cook();
                    isFoodPrepared = true;
                    return $"{egg.GetQuantity()} Egg Has been Prepared.";

                }

                else
                {
                    return "Something is wrong";
                }
            }


            catch (InvalidOperationException ex)
            {
                return ex.Message;
            }
        }









    }


}





// returns results of food preparation (string)