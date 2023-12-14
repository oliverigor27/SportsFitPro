using SportsFitPro.Models;

namespace SportsFitPro.Services.Register;

public class RegisterService : IRegisterService
{
    public Task<UserModel> CompleteRegister(Guid id, List<object> data)
    {
        throw new NotImplementedException();
    }

    public string ConfirmUser(Guid id)
    {
        string token = "andnskf5af54g51fdb1df5hw5re@@##f5we44fdR$";

        return token;
    }

    public async Task<UserModel> CreateUser(UserModel data)
    {
        return data;
    }
}