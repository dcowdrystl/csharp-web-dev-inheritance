using System;

namespace Cats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try out your skills with inheritance here!
            HouseCat bob = new HouseCat("bob", 10);
            Console.WriteLine(bob.IsSatisfied());
            Console.WriteLine(bob.Family);

            HouseCat bill = new HouseCat("bill");
            Console.WriteLine(bill.Weight);
        }
    }
}
