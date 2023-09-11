namespace OcampoITELEC1C.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class Instructor
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String IsTenured { get; set; }
        public Rank Rank { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
