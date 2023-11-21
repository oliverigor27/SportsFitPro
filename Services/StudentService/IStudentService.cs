namespace SportsFitPro.Services.StudentService;

public interface IStudentService 
{
    Student GetUser(int id);
    List<Student> GetAllUsers();
    List<Student> CreateNewUser(Student data);
    List<Student> UpdateUser(int id, Student request);
    List<Student> DeleteUser(int id);
}