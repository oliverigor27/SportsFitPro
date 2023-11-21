namespace SportsFitPro.Models;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string? TrainingPreference { get; set; }
    public string IDCard { get; set; } = string.Empty;
    public string Age { get; set; } = string.Empty;

}