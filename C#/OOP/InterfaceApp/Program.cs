using System;

namespace InterfaceApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Boy boy = new Boy();

            AtPartyHall(man);
            AtPartyHall(boy);
            AtCinemaHall(man);
            AtCinemaHall(boy);
        }

        private static void AtPartyHall(IManner manner)
        {
            manner.Wish();
            manner.Depart();
        }

        private static void AtCinemaHall(IEmotion emotion)
        {
            emotion.Cry();
            emotion.Laugh();
        }
    }
}
