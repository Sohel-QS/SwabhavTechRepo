using System;

namespace PersonBmiApp.Model
{
    class Person
    {
        private string _name;
        private int _age;
        private string _gender;
        private double _height;
        private double _weight;
        private double _bmi;
        private string _bodyStructure;

        public Person(string name, int age, string gender, double height, double weight)
        {
            _name = name;
            _age = age;
            _gender = gender;
            _height = height;
            _weight = weight;
        }

        public string GetName()
        {
            return _name;
        }
        public int GetAge()
        {
            return _age;
        }
        public string GetGender()
        {
            return _gender;
        }
        public double GetHeight()
        {
            return _height;
        }
        public double GetWeight()
        {
            return _weight;
        }

        public void WorkOut()
        {
            _weight -= _weight * 0.1;
        }

        public void Eat()
        {
            _height += _height * 0.02;
            _weight += _weight * 0.05;
        }

        public double GetBmi()
        {
            _bmi = Math.Round((_weight / (_height * _height)), 2);
            return _bmi;
        }

        public string GetBodyStructure()
        {
            if (_bmi < 18.5)
                _bodyStructure = "UnderWeight";
            else if (_bmi < 25.0)
                _bodyStructure = "Healthy";
            else if (_bmi < 30)
                _bodyStructure = "OverWeight";
            else
                _bodyStructure = "Obese";

            return _bodyStructure;
        }

    }
}
