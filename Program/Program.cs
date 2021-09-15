using System;

namespace Program
{
    class Program
    {
        const int IS_PRESENT=1, WAGE_PER_HOUR=20,FULL_DAY_HOUR=8;
        public void Attendance()
        {
            Random random = new Random();
            int emplyoeecheck = random.Next(1, 2);
            if (emplyoeecheck == IS_PRESENT)
            {
                int totalwage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                Console.WriteLine(totalwage);

            }
            else
                Console.WriteLine("Absent");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Attendance();
            Console.ReadLine(); 

        }
    }
}
