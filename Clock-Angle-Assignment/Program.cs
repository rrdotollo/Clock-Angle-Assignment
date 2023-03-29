using System;

namespace ClockAngleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time in this format '08:23'");
            string giventime = Console.ReadLine();

            // Validate the input format
            while (!IsValidTimeFormat(giventime) || !IsValidHourRange(giventime))
            {
                Console.WriteLine("Invalid time format. Please enter time in this format '08:23'");
                giventime = Console.ReadLine();
            }

            string hrstring = giventime.Substring(0, 2);
            string minstring = giventime.Substring(3, 2);
            int hhd = int.Parse(hrstring);
            int mhd = int.Parse(minstring);
            int returnValue = FindAng(hhd, mhd);
            Console.WriteLine(returnValue);
            Console.ReadLine();
        }

        public static int FindAng(int hhd, int mhd)
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

        public static bool IsValidTimeFormat(string input)
        {
            return DateTime.TryParseExact(input, "HH:mm", null, System.Globalization.DateTimeStyles.None, out _);
        }

        public static bool IsValidHourRange(string input)
        {
            string hrstring = input.Substring(0, 2);
            int hhd = int.Parse(hrstring);

            if (hhd >= 1 && hhd <= 12)
            {
                return true;
            }

            return false;
        }
    }
}
