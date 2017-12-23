using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample
{
    public class Mother
    {
        public void OpenTheDoorForGuest(object s, GuestArrivedEventArgs e)
        {
            Console.WriteLine($"Mother: *Goes to open the door for {e.Guest}*");
        }
    }
}
