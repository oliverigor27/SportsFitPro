using SportsFitPro.Models;

namespace SportsFitPro.Services.UserService;

public interface IUserService 
{
    UserModel GetUser(int id);
    List<UserModel> GetAllUsers();
    List<UserModel> CreateNewUser(UserModel data);
    List<UserModel> UpdateUser(int id, UserModel request);
    List<UserModel> DeleteUser(int id);
}


