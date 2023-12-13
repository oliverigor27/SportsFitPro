using SportsFitPro.Models;

namespace SportsFitPro.Services;

public interface IRegisterService 
{
    Task<UserModel> CreateUser(UserModel data);
    string ConfirmUser(string token);
    Task<UserModel> CompleteRegister(Guid id, List<Object> data);
}