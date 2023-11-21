namespace SportsFitPro.Services.StudentService;
class StudentService : IStudentService
{
    
    private static List<Student> StudentsContext = new List<Student> 
    {
        new Student {Id = 1, FirstName = "Igor", LastName = "Bomfim", Email = "igor@gmail.com", Password = "145679", Age = "27/05/1998", IDCard = "18476243122"},
        new Student {Id = 2, FirstName = "Igor", LastName = "Bomfim", Email = "igor@gmail.com", Password = "145679", Age = "27/05/1998", IDCard = "18476243122"},
    };

    public List<Student> CreateNewUser(Student data)
    {
        var studentExist = StudentsContext.Find(x => x.IDCard == data.IDCard);

        if(studentExist.FirstName == data.IDCard) return null;

        StudentsContext.Add(data);

        return StudentsContext;
    }

    public List<Student> DeleteUser(int id)
    {
        var studentExist = StudentsContext.Find(x => x.Id == id);

        if(studentExist is null) return null;

        StudentsContext.Remove(studentExist);

        return StudentsContext;

    }

    public List<Student> GetAllUsers()
    {
        return StudentsContext;
    }

    public Student GetUser(int id)
    {
        var studentExist = StudentsContext.Find(x => x.Id == id);

        if(studentExist is null) return null;

        return studentExist;
    }

    public List<Student> UpdateUser(int id, Student request)
    {
        var studentExist = StudentsContext.Find(x => x.Id == id);

        if(studentExist is null) return null;

        studentExist.Id = id;
        studentExist.Email = request.Email;
        studentExist.Password = request.Password;

        return StudentsContext;
    }
}