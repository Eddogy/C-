using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult MyStudents()
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() {StudentID = 1, StudentName = "John", Age = 18, StandardID = 1} ,
                new Student() {StudentID = 2, StudentName = "Steve", Age = 21, StandardID = 1} ,
                new Student() {StudentID = 3, StudentName = "Bill", Age = 18, StandardID = 2} ,
                new Student() {StudentID = 4, StudentName = "Ram", Age = 20, StandardID = 2} ,
                new Student() {StudentID = 5, StudentName = "Ron", Age = 21 }
            };

            return View(studentList);
        }
    }
}
