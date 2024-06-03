using AutoMapper;
using FridaReads.Server.Entities;
using FridaReads.Server.Models;
using FridaReads.Server.Repositories;

namespace FridaReads.Server.BusinessLogics
{
    public class UserBusinessLogic
    {
        private readonly UserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserBusinessLogic(UserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserModel> AddUser(UserModel userModel)
        {
            var user = _mapper.Map<User>(userModel);
            var addedUser = await _userRepository.AddAsync(user);
            return _mapper.Map<UserModel>(addedUser);
        }

        // only admins
        public void UpdateUser(User user) { }

        // only admins
        public void DeleteUser(User user) { }

        // public User GetUserById(int id) {}

        // only admins
        // public List<User> GetAllUsers() { }

    }
}
