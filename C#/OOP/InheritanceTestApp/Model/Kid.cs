using System;

namespace InheritanceTestApp.Model
{
    class Kid : Man
    {
        public override void Play()
        {
            Console.WriteLine("Kid is Playing");
        }
    }
}
