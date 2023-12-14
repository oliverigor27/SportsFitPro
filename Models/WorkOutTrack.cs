namespace SportsFitPro.Models;

public class WorkOutTrack 
{
    public string WorkOutName { get; set; } = string.Empty;
    public List<WorkoutSession>? WorkOutList { get; set; }
    public double PerformanceTrack { get; set; }
    public DateTime StartedAt { get; set; }
    public Guid UserId { get; set; }
    public UserModel? User { get; set; } 

}