using System;

namespace ClockAngleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time in this format '08:23'");
            string givenTime = Console.ReadLine();
            string hrstring = givenTime.Substring(0, 2);
            string minstring = givenTime.Substring(3, 2);
            int hhd = int.Parse(hrstring);
            int mhd = int.Parse(minstring);
            int returnValue = FindAngle(hhd, mhd);
            Console.WriteLine(returnValue);
            Console.ReadLine();
        }

        public static int FindAngle(int hhd, int mhd)
        {
            int ang1;
            int ang2;
            int answer;
            int hd = (hhd * 360) / 12;
            int md = (mhd * 360) / 60;

            ang1 = hd - md;
            ang2 = 360 - ang1;

            if (ang1 < ang2)
            {
                answer = ang1;
            }
            else if (ang2 < ang1)
            {
                answer = ang2;
            }
            else
            {
                answer = ang1;
            }

            return answer;
        }
    }
}