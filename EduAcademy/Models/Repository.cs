namespace EduAcademy.Models
{
  public static class Repository
  {
    private static List<Candidates> applications = new();
    public static IEnumerable<Candidates> Applications => applications;

    public static void Add(Candidates candidates)
    {
      applications.Add(candidates);
    }
  }  
}