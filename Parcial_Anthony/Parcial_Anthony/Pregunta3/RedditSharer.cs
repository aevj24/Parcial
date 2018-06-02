using ExamenParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial
{
    public class RedditSharer : Sharing
    {

        public void Share(string message)
        {
            Console.WriteLine("Message '" + message + "' shared on Reddit");
        }
    }
}
