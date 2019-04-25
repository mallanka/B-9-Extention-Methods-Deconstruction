using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base_Lesson_9.Practice;

namespace Base_Lesson_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practice.Practice.L9_P_EX_1_from_2();
            Practice.Practice.Coordinates coord = new Practice.Practice.Coordinates(3,4,5);
            var (newX, newY, newZ, length) = coord;
            Console.WriteLine(length);
            //Practice.Practice.L9_P_EX_2_from_2();
            DateTime date = new DateTime();
            var (_, _, _, currentHour, currentMinute, _) = date;
            Console.WriteLine(currentHour + " " + currentMinute);
            //Lesson.Lesson.DeconstructExample();
        }
    }
}
