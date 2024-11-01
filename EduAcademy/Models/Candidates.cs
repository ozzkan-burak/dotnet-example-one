
using System.ComponentModel.DataAnnotations;

namespace EduAcademy.Models
{
  public class Candidates
  {
    [Required(ErrorMessage = "Eposta zorunlu.")]
    public String? Email { get; set; } = String.Empty;
    [Required(ErrorMessage = "İsim zorunlu.")]
    public String? FirstName { get; set; } = String.Empty;
    [Required(ErrorMessage = "Soyisim zorunlu.")]
    public String? LastName { get; set; } = String.Empty;
    public String FullName => $"{FirstName} {LastName?.ToUpper()}";
    public int? Age { get; set; }
    public String? SelectedCourse { get; set; } = String.Empty;
    public DateTime ApplyAt { get; set; }
    
    public Candidates()
    {
      ApplyAt = DateTime.Now;
    }

  }
}