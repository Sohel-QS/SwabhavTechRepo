using System;

namespace InheritanceTestApp.Model
{
    class Boy : Man
    {
        public override void Play()
        {
            Console.WriteLine("Boy is Playing");
        }
        public void Jump()
        {
            Console.WriteLine("Boy isJumping");
        }
        //public override string ToString()
        //{
        //    return "Boy";
        //}
    }
}
