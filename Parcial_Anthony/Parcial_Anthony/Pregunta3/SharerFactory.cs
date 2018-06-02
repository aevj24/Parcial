using ConsoleAppParcial.Pregunta3;

namespace ExamenParcial
{
    class SharerFactory
    {
        private SharerFactory()
        {
        }

        public static SharerFactory Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        public FacebookSharer FacebookSharer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public TwitterSharer TwitterSharer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public ConsoleAppParcial.Pregunta3.PinterestSharer PinterestSharer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public RedditSharer RedditSharer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly SharerFactory instance = new SharerFactory();
        }

        public Sharing GetSharer(SharerType sharerType)
        {
            Sharing sharing = null;
            switch (sharerType)
            {
                case SharerType.Facebook: sharing = new FacebookSharer(); break;
                case SharerType.Twitter: sharing = new TwitterSharer(); break;
                case SharerType.Pinterest: sharing = new PinterestSharer(); break;
                case SharerType.Reddit: sharing = new RedditSharer(); break;
                default: break;
            }
            return sharing;
        }
    }
}