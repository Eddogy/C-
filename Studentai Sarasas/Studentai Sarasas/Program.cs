using System;
using System.Collections.Generic;
using System.Linq;

namespace Studentai_Sarasas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IList<Student> studentList = new List<Student>()
            {
                new Student() {StudentID = 1, StudentName = "John", Age = 18, StandardID = 1} ,
                new Student() {StudentID = 2, StudentName = "Steve", Age = 21, StandardID = 1} ,
                new Student() {StudentID = 3, StudentName = "Bill", Age = 18, StandardID = 2} ,
                new Student() {StudentID = 4, StudentName = "Ram", Age = 20, StandardID = 2} ,
                new Student() {StudentID = 5, StudentName = "Ron", Age = 21 }
            };

            IEnumerable<Student> studentsThatare18 = studentList.Where(x => x.Age <= 18);
            // IList<Student> studentsOver18 = studentList.Where(x => x.Age <= 18).ToList();
            // to list ant galo rasome kai jau baigeme su sarasu kai baigem manipuliuoti su ja
            foreach (var item in studentsThatare18)
            {
                Console.WriteLine(item.StudentName);
            }
            

            Student penktasStudentas = studentList.FirstOrDefault(x => x.StudentID == 5);
            if (penktasStudentas != null)
            {
                Console.WriteLine(penktasStudentas.StudentName);
            }
            

        }
    }
}
