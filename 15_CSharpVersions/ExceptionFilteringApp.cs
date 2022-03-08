using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_CSharpVersions
{
    public class ExceptionFilteringApp
    {
        public static void ExFilterExample()
        {
            var done = false;
            do
            {
                int failures = 0;
                try
                {
                    var data = SimulatedWebRequest();
                    workWith(data);
                    done = true;
                }
                catch (TimeoutException e) when (failures++ < 10)
                {
                    Console.WriteLine("Timeout error: trying again");
                }
            } while (!done);
        }

        private static void workWith(object data)
        {
            throw new NotImplementedException();
        }

        private static object SimulatedWebRequest()
        {
            throw new NotImplementedException();
        }

       // exception filtering
         public   int GetInt(int[] array, int index)
            {
                try
                {
                    return array[index];
                }
                catch (IndexOutOfRangeException e) when (index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Parameter index cannot be negative.", e);
                }
                catch (IndexOutOfRangeException e)
                {
                    throw new ArgumentOutOfRangeException(
                        "Parameter index cannot be greater than the array size.", e);
                }
            }
       
    }
}
