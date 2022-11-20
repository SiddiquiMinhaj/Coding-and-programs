using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumProj
{
    public enum meet
    {
        Monday = 1,
        Tuesday = 22,
        Wednesday = 33,
        Thursday = 44,
        Friday = 55,
    }
    internal class MeetingDay
    {
        public static meet meetDate
        {
            get; set;
        } = meet.Monday;

        static void Main()
        {
            Console.WriteLine(meetDate);
            //  meetDate = "Saturday"; // here we cannot assign the value as Saturday reason 1. we have not give change to schedule the meet on saturday the chance is give to above 5 days
                                       // 2.  Sturday is string type and meeting day is enum type so we should assign value with Enum only, see below
            meetDate=meet.Thursday; // here you can choose now the day which is available in Enum list
            Console.WriteLine(meetDate); 
            Console.ReadLine();
        }
        

    }
}
