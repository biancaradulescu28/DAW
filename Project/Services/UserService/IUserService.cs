using DAL.Models;
using DAL.Models.DTOs;

namespace Project.Services.UserService
{
    public interface IUserService
    {
        UserResponseDTO Atuhentificate(UserRequestDTO model);//am nevoie de generare token
        User GetById(Guid id);

        Task Create(User newUser);
        Task<List<User>> GetAllUsers();
    }
}
