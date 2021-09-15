using System;

namespace Program
{
    class Program
    {
        const int IS_PRESENT=1;
        public void Attendance()
        {
            Random random = new Random();
            int emplyoeecheck = random.Next(0, 2);
            if (emplyoeecheck == IS_PRESENT)
                Console.WriteLine("Present");
            else
                Console.WriteLine("Absent");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Attendance();
        }
    }
}
