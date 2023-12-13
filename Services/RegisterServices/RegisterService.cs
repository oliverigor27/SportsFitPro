using SportsFitPro.Models;

namespace SportsFitPro.Services;

public class RegisterService : IRegisterService
{
    public Task<UserModel> CompleteRegister(Guid id, List<object> data)
    {
        throw new NotImplementedException();
    }

    public string ConfirmUser(string token)
    {
        throw new NotImplementedException();
    }

    public async Task<UserModel> CreateUser(UserModel data)
    {
        UserModel user = new()
        {
            UserName = "Lolita1233",
            Email = "igoroliveira2798@gmail.com",
            Password =  "dbfkjsbfjkbaj"
        };

        return user;
    }
}