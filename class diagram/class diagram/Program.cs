using System;
namespace class_diagram
{
    class Program : ProgramBase
    {
        private static int hoursWorked;
        private static int basePay;
        private static int overtimeHours;
        private static int overtimePay;
        private static int unitPay;

        public static int Grosspay { get; private set; }

        private static int hourlyPayRate;
        private static int unitproduced;

        public static int BASE_HOURS { get; private set; }
        public static int OVERTIME_RATE { get; private set; }
        public static int UnitPay { get => unitPay; set => unitPay = value; }
        public static int HoursWorked { get => hoursWorked; set => hoursWorked = value; }
        public static int Unitproduced { get => unitproduced; set => unitproduced = value; }
        public static int HourlyPayRate { get => hourlyPayRate; set => hourlyPayRate = value; }

        static void Main(string[] args)
        {
            throw new NotImplementedException();
            {
                if (HoursWorked <= BASE_HOURS)
                {
                    return;
                }
                //calculate hourly pay without over time
                basePay = HourlyPayRate * BASE_HOURS;

                //calculate overtime hours
                overtimeHours = HoursWorked - BASE_HOURS;

                //calculate overtime pay
                overtimePay = overtimeHours * HourlyPayRate * OVERTIME_RATE;

                //calculate unit pay
                UnitPay = 3 * Unitproduced;

                //calculate gross pay
                Grosspay = basePay + overtimePay + UnitPay;

            }
        }
    }
}
