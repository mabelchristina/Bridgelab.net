using System;

namespace Program
{
    class Program
    {
        const int IS_PRESENT=1, WAGE_PER_HOUR=20,FULL_DAY_HOUR=8,PART_TIME_HOUR=4;
        int totalwage=0;
        public void Attendance()
        {
            Random random = new Random();
            int emplyoeecheck = random.Next(0,2);
            if (emplyoeecheck == IS_PRESENT)
            {
                this.totalwage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                return;
            }
            else
                this.totalwage = WAGE_PER_HOUR * PART_TIME_HOUR;
            return;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Attendance();
            Console.ReadLine(); 

        }
    }
}
