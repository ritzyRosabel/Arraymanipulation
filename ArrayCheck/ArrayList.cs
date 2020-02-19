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
    
