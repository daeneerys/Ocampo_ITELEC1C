using System.ComponentModel.DataAnnotations;

namespace OcampoITELEC1C.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }

    public class Student
    {

        [Display( Name = "FirstName")]
        [Required(ErrorMessage = " * First Name is Required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "* Last Name is required")]
        public string LastName { get; set; }

        [Display(Name = "GPA")]
        [Required(ErrorMessage = "* GPA is required")]
        public double GPA { get; set; }


        [Display(Name = "Course")]
        [Required(ErrorMessage = "* Course is required")]
        public Course Course { get; set; }


        [Display(Name = "GPA")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "* Admission Date is required")]
        public DateTime AdmissionDate { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "* Email is required")]
        public string Email { get; set; }

        public int Id { get; set; }

    }
}
