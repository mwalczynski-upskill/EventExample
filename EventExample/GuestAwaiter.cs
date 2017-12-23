using System;

namespace EventExample
{
    public delegate void GuestArrivedHandler(object sender, GuestArrivedEventArgs e);

    public class GuestAwaiter
    {
        public event GuestArrivedHandler GuestArrived;

        public void WaitForGuest(string guestName)
        {
            Console.WriteLine("Waiting for guest...");
            System.Threading.Thread.Sleep(1000);
            var guestArrivedEventArgs = new GuestArrivedEventArgs(guestName);
            OnGuestArrived(guestArrivedEventArgs);
        }

        private void OnGuestArrived(GuestArrivedEventArgs e)
        {
            Console.WriteLine($"{e.Guest} arrived!");
            GuestArrived?.Invoke(this, e);
        }
    }
}
