namespace SportsFitPro.Models;

class CoachModel
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string IDCard { get; set; } = string.Empty;
    public DateTime Age { get; set; }
    public List<Student>? StudentsList { get; set; }
    public string specialty { get; set; } = string.Empty;

}