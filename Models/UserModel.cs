namespace SportsFitPro.Models
{
    public class UserModel 
    {
        public Guid UserId { get; set; }
        public string  UserName  { get; set; } = string.Empty;
        public string  Email     { get; set; } = string.Empty;
        public string  Password  { get; set; } = string.Empty;
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName  { get; set; } = string.Empty;
        public double? Height    { get; set; }
        public double? Weight    { get; set; }
        public List<WorkOutTrack>? WorkOutTrack { get; set; }
    }
}