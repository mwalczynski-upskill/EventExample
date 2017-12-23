using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample
{
    public class GuestArrivedEventArgs : EventArgs
    {
        public string Guest { get; }

        public GuestArrivedEventArgs(string guest)
        {
            Guest = guest;
        }
    }
}
