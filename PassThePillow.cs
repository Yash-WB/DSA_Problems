using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_ProblemsDa2
{
    class PassThePillow
    {
        public static int PassTheP(int n, int time)
        {
            int person = 1;
            int current_time = 0;
            for (int i = 1; i <= time; i++)
            {
                person++;
                current_time++;
                if (time == current_time)
                {
                    return person;
                }
                if (person == n)
                {
                    while (person != 1 && time != current_time)
                    {
                        person--;
                        current_time++;
                        if (time == current_time)
                        {
                            return person;
                        }
                    }
                }
            }
            return person;
        }
        static void Main(string[] args)
        {
            int n = 4;
            int time = 5;

            Console.WriteLine(PassThePillow.PassTheP(n, time));
        }
    }
}
