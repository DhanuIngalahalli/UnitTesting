using System;

namespace UnitTesting
{
   
  public class DayOfWeek
        {
            
            public static void Days(int month, int day, int year)
            {
                string[] days = { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };
                int dayIndex = Utility.Days(month, day, year);
                Console.WriteLine("day= " + days[dayIndex]);
            }
        }
    }
