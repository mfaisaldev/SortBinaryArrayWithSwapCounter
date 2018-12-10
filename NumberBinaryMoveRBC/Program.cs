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
            //List<int> lst = new List<int>() { 1, 0, 1, 0, 0, 0, 0, 1 };
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
                        
            for(int te=0;te<avg.Count;te++)
            {
                if(avg[te]==0)
                {
                    for(int op=te;op<avg.Count;op++)
                    {
                        if(avg[op]==1)
                        {
                            counter += mover(avg);
                        }
                    }
                }
            }
            foreach (int io in avg)
            {
                Console.WriteLine(io);
            }

            return counter;
        }
        public static int mover(List<int> avg)
        {
            int counter = 0;
            for (int outer = 1; outer <= avg.Count; outer++)
            {
                for (int ik = avg.Count - outer; ik > 0; ik--)
                {
                    if (avg[ik] == 0)
                    {
                        avg[ik] = avg[ik];
                    }
                    else
                    {
                        if (avg[ik - 1] == 0)
                        {
                            int old = avg[ik - 1];
                            avg[ik - 1] = avg[ik];
                            avg[ik] = old;
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
