using System;

namespace ClassTestApp.Model
{
    public class Student
    {
        protected int score;
        private string name;
        private string location;

        public Student()
        {
            score = 0;
            name = "xyz";
            location = "India";
        }

        ~Student()
        {
            Console.WriteLine(name + " " + location + " " + score);
        }

        public void SetName(string studentName)
        {
            name = studentName;
        }
        public string GetName()
        {
            return name;
        }
        public void SetLocation(string studentLoc)
        {
            location = studentLoc;
        }
        public string GetLocation()
        {
            return location;
        }
        public void SetScore(int studentScore)
        {
            score = studentScore;
        }
        public int GetScore()
        {
            return score;
        }

        
    }
}
