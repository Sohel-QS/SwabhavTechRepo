using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCollegeApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor[] professors = new Professor[3];
            Student[] students = new Student[3];

            InitializeProfessor(professors);
            InitializeStudent(students);

            ProfessorsDetails(professors);
            StudentssDetails(students);
        }

        private static void StudentssDetails(Student[] students)
        {
            foreach(Student student in students)
            {
                Console.WriteLine("Id :{0}\nAddress :{1}\nDOB :{2}\nBranch :{3}\n",
                student.ID, student.Address, student.DOB, student.Branch);
            }
        }

        private static void ProfessorsDetails(Professor[] professors)
        {
            foreach (Professor professor in professors)
            {
                professor.CalculateSalary();
                Console.WriteLine("Id :{0}\nAddress :{1}\nDOB :{2}\nSalary :{3}\nNet Salary :{4}\nPF :{5}\n",
                professor.ID, professor.Address, professor.DOB, professor.Salary, professor.NetSalary, professor.Pf);
            }
        }

        private static void InitializeStudent(Student[] students)
        {
            students[0] = new Student(101, "Dombivli East", "19/7/2000", "Computer");
            students[1] = new Student(102, "Kalyan East", "29/5/1999", "IT");
            students[2] = new Student(103, "Kurla East", "30/12/1998", "Civil");
        }

        private static void InitializeProfessor(Professor[] professors)
        {
            professors[0] = new Professor(101, "Dombivli East", "12/7/1990", 40000, 0.03f);
            professors[1] = new Professor(102, "Kalyan East", "21/5/1985", 50000, 0.05f);
            professors[2] = new Professor(103, "Thane East", "29/11/1995", 30000, 0.02f);
        }
    }
}
