using System;
using System.Globalization;

namespace Dizon.SingletonDesignPattern
{

    class Attendance
    {
        static void Main(string[] args)
        {
            AttendanceMonitoring attendanceMonitoring = AttendanceMonitoring.Instance;
            attendanceMonitoring.AvailabilityTracker();
        }
    }

    public class AttendanceMonitoring
    {
        private static AttendanceMonitoring instance = new AttendanceMonitoring();
        private AttendanceMonitoring() { }

        public static AttendanceMonitoring Instance
        {
            get { return instance; }
        }

        public void AvailabilityTracker()
        {
            Console.WriteLine("Please log your working location for proper attendance monitoring.");
            Console.WriteLine("\nTYPE: WFH [Working from Home]     WFCS [Working from Client Site]      SL [Sick Leave]     VL [Vacation Leave]");
            Console.Write("> ");
            string status = Console.ReadLine();

            if (status == "WFH")
            {
                Console.WriteLine("\nYour record status is WORK FROM HOME at " + DateTime.Now.ToString());
            }
            else if (status == "WFCS")
            {
                Console.WriteLine("\nYour record status is WORKING FROM CLIENT SITE at " + DateTime.Now.ToString());
            }
            else if (status == "SL")
            {
                Console.WriteLine("\nYour record status is SICK LEAVE at " + DateTime.Now.ToString());
            }
            else if (status == "VL")
            {
                Console.WriteLine("\nYour record status is VACATION LEAVE at " + DateTime.Now.ToString());
            }
            else
            {
                Console.WriteLine("\nFailed to log your attendance tracker." + DateTime.Now.ToString());
            }
        }
    }
}
