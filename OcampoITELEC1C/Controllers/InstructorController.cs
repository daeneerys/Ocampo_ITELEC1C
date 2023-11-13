using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OcampoITELEC1C.Models;
using OcampoITELEC1C.Serivces;
using System.Reflection.Metadata;
using OcampoITELEC1C.Data;

namespace OcampoITELEC1C.Controllers
{
    
    public class InstructorController : Controller
    {
        private readonly  AppDbContext _db;
        public InstructorController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Instructors);
        }

        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = _db.Instructors.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            if (!ModelState.IsValid) //if the date is invalid
                return View();

            _db.Instructors.Add(newInstructor);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Instructor? instructor = _db.Instructors.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Instructor instructorChange)
        {
            Instructor? instructor = _db.Instructors.FirstOrDefault(ins => ins.Id == instructorChange.Id);

            if(!ModelState.IsValid)
                return View();

            if (instructor != null)
            {
                instructor.FirstName = instructorChange.FirstName;
                instructor.LastName = instructorChange.LastName;
                instructor.Rank = instructorChange.Rank;
                instructor.IsTenured = instructorChange.IsTenured;
                instructor.HiringDate = instructorChange.HiringDate;

                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {

            Instructor? instructor = _db.Instructors.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Delete(Instructor instructorDelete)
        {
            Instructor? instructor = _db.Instructors.FirstOrDefault(ins => ins.Id == instructorDelete.Id);
            if (instructor != null)
            {
                _db.Instructors.Remove(instructor);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
