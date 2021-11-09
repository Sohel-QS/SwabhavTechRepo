using System;

namespace InheritanceTestApp.Model
{
    class Infant : Man
    {
        public override void Play()
        {
            Console.WriteLine("Infant Is Playing");
        }
    }
}
