using System;
using PersonBmiApp.Model;

namespace PersonBmiApp
{
    class BmiTest
    {
        static void Main(string[] args)
        {
            OnePerson();
            //ManyPeople();
        }

        private static void ManyPeople()
        {
            Person[] people = new Person[5];

            people[0] = new Person("Manish", 22, "Male", 1.60, 45);
            people[1] = new Person("Sohel", 21, "Male", 1.63, 57);
            people[2] = new Person("Surbhi", 22, "Female", 1.55, 70);
            people[3] = new Person("Samnit", 22, "Male", 1.75, 100);
            people[4] = new Person("Neha", 22, "Female", 1.55, 53);

            PrintDetails(people);
        }

        private static void PrintDetails(Person[] people)
        {
            foreach(Person person in people)
            {
                Console.WriteLine("Name :{0}\nAge :{1}\nGender :{2}\nBMI :{3}\nBody Type :{4}\n"
                    , person.GetName(), person.GetAge(), person.GetGender(), person.GetBmi(), person.GetBodyStructure());
            }
        }

        private static void OnePerson()
        {
            Person person = new Person("Sohel", 21, "Male", 1.63, 57.5);
            double bmi = person.GetBmi();
            Console.WriteLine("Bmi is :{0}", bmi);
            person.Eat();
            bmi = person.GetBmi();
            Console.WriteLine("Bmi After Eat :{0}", bmi);
            person.Eat();
            bmi = person.GetBmi();
            Console.WriteLine("Bmi After Eat :{0}", bmi);
            person.WorkOut();
            bmi = person.GetBmi();
            Console.WriteLine("Bmi After Workout :{0}", bmi);

            PrintDetails(person);
        }

        private static void PrintDetails(Person person)
        {
            Console.WriteLine("Name :{0}\nAge :{1}\nGender :{2}\nBMI :{3}\nBody Type :{4}\n"
                , person.GetName(), person.GetAge(), person.GetGender(), person.GetBmi(), person.GetBodyStructure());
        }
    }
}
