using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample
{
    public class Child
    {
        public void Hide(object s, GuestArrivedEventArgs e)
        {
            Console.WriteLine($"Child: *Hides from {e.Guest}*");
        }
    }
}
