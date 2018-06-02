using System;

namespace ExamenParcial
{
    public class FacebookSharer : Sharing
    {
        public void Share(string message)
        {
            Console.WriteLine("Message '" + message + "' shared on Facebook");
        }
    }
}