using System;

namespace Program
{
    class Program
    {
        const int IS_FULLTIME=0,IS_PARTTIME=1, WAGE_PER_HOUR=20,FULL_DAY_HOUR=8,PART_TIME_HOUR=4;
        int totalwage=0, emphours=0;
        public void Attendance()
        {
            Random random = new Random();
            for(int i=0; i<20; i++)
            { 
                int emplyoeecheck = random.Next(1, 3);
            switch (emplyoeecheck)
            {
                case IS_FULLTIME:
                    emphours += FULL_DAY_HOUR;
                    break;
                case IS_PARTTIME:
                    emphours += PART_TIME_HOUR;
                    break;
                default:
                    emphours += 0;
                    break;
            }
                this.totalwage = WAGE_PER_HOUR * emphours;
            }    
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int Wage = p.totalwage;
            Console.WriteLine(Wage);
            Console.ReadLine();

        }
    }
}
