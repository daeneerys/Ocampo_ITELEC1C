using System;
using OcampoITELEC1C.Models; 
namespace OcampoITELEC1C.Serivces
{
    public interface IMyFakeDataService
    {
        List<Instructor> InstructorList { get; }
        List<Student> StudentList { get; }
    }
}
