using System;

namespace ParkingSystem
{
    public class Person
    {
        public static void Main(string[] args)
        {
            Parking parking = new Parking();
           Console.WriteLine(parking.ParkingSpace());
        }
    }
}
