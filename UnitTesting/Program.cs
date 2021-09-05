using System;

namespace UnitTesting
{
    class Program
    {

        public class VendingMachine
        {
           
            public VendingMachine()
            {
                Console.WriteLine("Enter money amount:");
                int money = Convert.ToInt32(Console.ReadLine());
                int[] notes = new int[] { 1, 2, 5, 10, 50, 500, 1000 };
                int length = notes.Length;
                Utility utility = new Utility();
                Console.WriteLine("Minimum Notes= " + utility.MinNotes(notes, length, money));
            }
        }
    }
}
