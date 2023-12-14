using SportsFitPro.Models;

namespace SportsFitPro.Services.Register;

public interface IRegisterService 
{
    Task<UserModel> CreateUser(UserModel data);
    string ConfirmUser(Guid id);
    Task<UserModel> CompleteRegister(Guid id, List<Object> data);
}