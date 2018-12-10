using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberBinaryMoveRBC
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This program will sort array of Binary Digits and will count number of swaps
            List<int> lst = new List<int>() { 1, 0, 1, 0, 0, 0, 0, 1 };*/
            List<int> lst = new List<int>() { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0 };
            Console.WriteLine(Result.minMoves(lst));
            Console.ReadLine();
        }
    }

    class Result
    {

        /*
         * Complete the 'minMoves' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY avg as parameter.
         */

        public static int minMoves(List<int> avg)
        {
            int counter = 0;

            /* this loop will make sure there is no ZERO on the left of any ONE.
             If {1,1,1,1,0,1} This loop will run unless {1,1,1,1,1,0} is achieved */
            for (int te = 0; te < avg.Count; te++)
            {
                /* If ZERO found. */
                if (avg[te] == 0)
                {
                    /* This loop will check if any ONE is there after ONE */
                    for (int op = te; op < avg.Count; op++)
                    {
                        /*If ONE is found after ZERO means sort again
                        If ONE is not fount after ZERO, means everything is sorted.*/
                        if (avg[op] == 1)
                        {
                            /* counter is counting the number of swap
                             mover is a method which is sorting array and moving ZERO to right so all ONE will appear on LETF
                             if {1,1,1,0,1} mover method will make it {1,1,1,1,0}*/
                            counter += mover(avg);
                        }
                    }
                }
            }
            /*This is simply printing the output array*/
            foreach (int io in avg)
            {
                Console.WriteLine(io);
            }

            return counter;
        }

        /* This method is swaping values and sorting Array */
        public static int mover(List<int> avg)
        {
            int counter = 0;
            /* This loop will run till the length of Array */
            for (int outer = 1; outer <= avg.Count; outer++)
            {
                /* This loop will find ONE and move it to LEFT for sorting
                All ZEROs will be moved to RIGHT so array{1,1,0,0,1,1,} will become {1,1,1,1,0,0}*/
                for (int ik = avg.Count - outer; ik > 0; ik--)
                {
                    /* If ZERO is found, there will be no swapping */
                    if (avg[ik] == 0)
                    {
                        avg[ik] = avg[ik];
                    }
                    else
                    {
                        /* If ONE is found, then it will check the LEFT side of ONE, it it contains ZERO, there wil be SWAPPING
                         For example Swapping if {0,1} but no Swapping if {0,0} */
                        if (avg[ik - 1] == 0)
                        {
                            int old = avg[ik - 1];
                            avg[ik - 1] = avg[ik];
                            avg[ik] = old;
                            /* Counter for counting SWAP */
                            counter++;
                            break;
                        }
                    }
                }
            }
            return counter;
        }
    }

}
