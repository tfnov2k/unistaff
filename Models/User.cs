using System.ComponentModel.DataAnnotations;

namespace PerformanceEvaluation.Models
{
    public enum Department
    {
        FOICDT,
        FLM,
        FOE,
        FOS,
        FSSH,
        FOA
    }

    public enum Rank
    {
        Dean,
        HOD,
        AssLect,
        Lect,
        SenLect,
    }

    public enum Title
    {
        Mr,
        Mrs,
        Miss
    }

    public class User
    {
        public int Id { get; set; }
        [Required] 
        public string? FirstName { get; set; }
        [Required] 
        public string? LastName { get; set; }
        [Required] 
        public string? Gender { get; set; }
        [Required] 
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DateBeforeToday(ErrorMessage = "Date of birth must be before today.")]
        public DateTime DOB { get; set; }
        [Required] 
        public Department Department { get; set; }
        
        [Required]
        public Title Title { get; set; }
        public Rank Rank { get; set; }
        [Required]
        [RegularExpression(@"^5\d{7}$", ErrorMessage = "Phone number must start with 5 and be exactly 8 digits.")]
        public string PhoneNo { get; set; }
    }
}
