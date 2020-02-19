using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCheck
{
    public class ArrayList
    /* This project accepts integers, sorts the integers in descending order 
    and gives the total number of times the integer got swapped*/
    {
        static void Main(string[] args)
        {
        }

        public static string Sort(int[] myArray)
        {

            int swapCount = 0;

            for (int i = myArray.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (myArray[j] < myArray[j + 1])
                    {
                        swapCount += swap(myArray, j, j + 1);
                    }
                }
            }


            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            return ("Number of swap ==> " + swapCount);
        }



        static int swap(int[] array, int i, int j)
        {

            if (array[i] == array[j])
            {
                return 0;
            }

            int temp = array[j];
            array[j] = array[i];
            array[i] = temp;
            return 1;
        }

    }

}
    
