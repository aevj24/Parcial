using System;

namespace ExamenParcial
{
    class Client2
    {
        static void Main2(string[] args)
        {
            Sharer sharer = new Sharer();
            sharer.Share("Mastering design patterns", SharerType.Facebook);
            sharer.ShareEveryWhere("I'll receive my Master's degree from UNMSM very soon");

            Sharer sharerPinterest = new Sharer();
            sharerPinterest.Share("Mastering design patterns", SharerType.Pinterest);
            sharerPinterest.ShareEveryWhere("I'll receive my Master's degree from UNMSM very soon");


            Console.ReadLine();
        }
    }
}
