using Microsoft.AspNetCore.Mvc;
using OcampoITELEC1C.Models;

namespace OcampoITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
        {
            new Instructor()
            {
                Id = 100, FirstName = "Gabriel", LastName = "Montano", IsTenured = "Permanent", Rank = Rank.Professor, 
                HiringDate = DateTime.Parse("2020-09-11") 
            },
            new Instructor()
            {
                Id = 200, FirstName = "Lebron", LastName = "James", IsTenured = "Probationary", Rank = Rank.Instructor,
                HiringDate = DateTime.Parse("2023-09-11")
            },
            new Instructor() {
                Id = 300, FirstName = "Jessamine", LastName = "Lyndon", IsTenured = "Probationary", Rank = Rank.AssistantProfessor,
                HiringDate = DateTime.Parse("2023-09-11")
            },
            new Instructor()
            {
                Id = 101, FirstName = "Marje", LastName = "Algernon", IsTenured = "Permanent", Rank = Rank.AssistantProfessor,
                HiringDate = DateTime.Parse("2021-05-20")
            }
        };
        public IActionResult Index()
        {
            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(ins => ins.Id == id);

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
            InstructorList.Add(newInstructor);

            return View("Index", InstructorList);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Instructor instructorChange)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(ins => ins.Id == instructorChange.Id);

            if (instructor != null)
            {
                instructor.Id = instructorChange.Id;
                instructor.FirstName = instructorChange.FirstName;
                instructor.LastName = instructorChange.LastName;
                instructor.Rank = instructorChange.Rank;
                instructor.IsTenured = instructorChange.IsTenured;
                instructor.HiringDate = instructorChange.HiringDate;
            }
            return View("Index", InstructorList);
        }
    }
}
