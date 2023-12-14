using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SportsFitPro.Services.Register;
using SportsFitPro.Models;

namespace SportsFitPro.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RegisterController : ControllerBase 
{
    private readonly IRegisterService _registerService;

    public RegisterController(IRegisterService registerService)
    {
        _registerService = registerService;        
    }

    [HttpPost]
    public async Task<ActionResult<UserModel>> createUser(UserModel user) {

        await  _registerService.CreateUser(user);

        return Ok( new { Message = "User Created!", user.UserId });
    
    }

    [HttpPost("{id}")]
    public async Task<ActionResult> ConfirmPassword(Guid id) {

        var token = _registerService.ConfirmUser(id);

        return Ok(new { Message = $"Usuário {id} cadastrado com sucesso na base de dados!", token });
    }
}