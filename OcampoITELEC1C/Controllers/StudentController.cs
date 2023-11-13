using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using OcampoITELEC1C.Data;
using OcampoITELEC1C.Models;
using OcampoITELEC1C.Serivces;

namespace OcampoITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _db;

        public StudentController(AppDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            
            return View(_db.Students);
        }

        public IActionResult ShowDetails(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _db.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();

        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {

            if (!ModelState.IsValid) //if the date is invalid
                return View();

            _db.Students.Add(newStudent);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student? student = _db.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Student studentChange)
        {
            Student? student = _db.Students.FirstOrDefault(st => st.Id == studentChange.Id);

            if (student != null)
            {
                student.Id = studentChange.Id;
                student.FirstName = studentChange.FirstName;
                student.LastName = studentChange.LastName;
                student.Email = studentChange.Email;
                student.Course = studentChange.Course;
                student.AdmissionDate = studentChange.AdmissionDate;
                student.GPA = studentChange.GPA;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        [HttpGet]
        public IActionResult Delete (int id)
        {
            Student? student = _db.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Delete (Student studentDelete)
        {
            Student? student = _db.Students.FirstOrDefault(st => st.Id == studentDelete.Id);

            if (student != null)
            {
                _db.Students.Remove(student);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
