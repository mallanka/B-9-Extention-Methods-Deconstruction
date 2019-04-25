using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Lesson_9.Practice
{
    public static class Practice
    {
        /// <summary>
        /// L9-P-EX-1/2
        /// Создать структуру Coordinates (трехмерных). 
        /// Добавить экземплярный метод деконструкции значений координат.
        /// Вывести на консоль длину вектора по координатам.
        /// </summary>
        public struct Coordinates
        {
            private int x, y, z;

            public Coordinates(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public void Deconstruct(out int newX, out int newY, out int newZ, out double length)
            {
                newX = x;
                newY = y;
                newZ = z;
                length = Math.Sqrt(newY * newX + newY * newY + newZ * newZ);
            }
        }

        public static void L9_P_EX_1_from_2()
        {

        }




        /// <summary>
        /// L9-P-EX-2/2. 
        /// Создать деконструктор для обьекта DateTime 
        /// (год, месяц, день, час, минуты, секунды). 
        /// Получить и вывести на консоль текущее время.
        /// Использовать пустые параметры.
        /// </summary>
        public static void L9_P_EX_2_from_2()
        {

        }
    }

    public static class ExtentionDateTime
    {
        public static void Deconstruct(this DateTime date, out int year, out int month, out int day, out int hour, out int minute, out int second)
        {
            year = DateTime.Now.Year;
            month = DateTime.Now.Month;
            day = DateTime.Now.Day;
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
        }
    }
}
