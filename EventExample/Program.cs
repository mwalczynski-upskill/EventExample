using System;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var father = new Father();
            var mother = new Mother();
            var child = new Child();

            var guestAvaiter = new GuestAwaiter();

            guestAvaiter.GuestArrived += father.TakeOutAlcohol;
            guestAvaiter.GuestArrived += mother.OpenTheDoorForGuest;
            guestAvaiter.GuestArrived += child.Hide;

            guestAvaiter.WaitForGuest("Marian");

            Console.ReadKey();
        }
    }
}
