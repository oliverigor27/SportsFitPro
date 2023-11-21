using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsFitPro.Models;
using SportsFitPro.Services.StudentService;

namespace SportsFitPro.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService) {
        _studentService = studentService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Student>>> getAllStudents() 
    {
        var result = _studentService.GetAllUsers();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Student>> getSingleStudent(int id) 
    {
        var result = _studentService.GetUser(id);

        if(result is null) return NotFound("User does not founded!");

        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<List<Student>>> CreateNewStudent(Student student) 
    {
        var result = _studentService.CreateNewUser(student);
        if(student != null) return BadRequest("This student already exist!");

        return Ok(result);
    }
}