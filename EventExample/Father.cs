using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample
{
    public class Father
    {
        public void TakeOutAlcohol(object s, GuestArrivedEventArgs e)
        {
            Console.WriteLine($"Father: *Takes out alcohol to drink with {e.Guest}*");
        }
    }
}
