using System;

namespace InheritanceTestApp.Model
{
    class Man
    {
        public void Read()
        {
            Console.WriteLine("Man is Reading");
        }
        public virtual void Play()
        {
            Console.WriteLine("Man is Playing");
        }
        public void Walk()
        {
            Console.WriteLine("Man is Walking");
        }
        //public override string ToString()
        //{
        //    return "Man";
        //}
    }
}
