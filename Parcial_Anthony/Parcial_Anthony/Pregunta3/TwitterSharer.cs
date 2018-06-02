using System;

namespace ExamenParcial
{
    public class TwitterSharer : Sharing
    {
        public void Share(string message)
        {
            Console.WriteLine("Message '" + message + "' shared on Twitter");
        }
    }
}