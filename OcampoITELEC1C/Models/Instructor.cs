using System.ComponentModel.DataAnnotations;

namespace OcampoITELEC1C.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class Instructor

    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "* First Name is required")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "* Last Name is required")]
        public String LastName { get; set; }

        [Display(Name = "Is Tenured")]
        public String IsTenured { get; set; }

        [Display(Name = "Rank")]
        public Rank Rank { get; set; }

        [Display(Name = "Hiring Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Hiring Date is required")]
        public DateTime HiringDate { get; set; }

 
      
       
    }
}
