using DAL.Models;
using DAL.Models.DTOs;
using DAL.Repositories.UserRepository;
using Project.Helper.JwtUtils;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Project.Services.UserService
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        private IJwtUtils _jwtUtils;

        public UserService(IUserRepository userRepository, IJwtUtils jwtUtils)
        {
            _userRepository = userRepository;
            _jwtUtils = jwtUtils;
        }

        public UserResponseDTO Atuhentificate(UserRequestDTO model)
        {
            var user = _userRepository.FindByUsername(model.UserName);//caut user dupa username
            if (user == null || !BCryptNet.Verify(model.Password, user.PasswordHash))//daca nu exista user sau parola gresita
            {
                return null; //or throw exception
            }

            // jwt generation
            var jwtToken = _jwtUtils.GenerateJwtToken(user);//generam token
            return new UserResponseDTO(user, jwtToken);
        }

        public async Task Create(User newUser)
        {
            await _userRepository.CreateAsync(newUser);
            await _userRepository.SaveAsync();
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetAll();
        }

        public User GetById(Guid id)
        {
            return _userRepository.FindById(id);
        }
    }
}
