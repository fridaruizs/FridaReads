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

        
        public async Task<UserModel> UpdateUser(UserModel userModel)
        {
            // only admins
            var user = _mapper.Map<User>(userModel);
            var updatedUser = await _userRepository.UpdateAsync(user);
            return _mapper.Map<UserModel>(updatedUser);
        }

        public async Task DeleteUser(UserModel userModel)
        {
            // only admins
            var user = _mapper.Map<User>(userModel);
            await _userRepository.DeleteAsync(user);
        }
        public async Task<UserModel> GetUserById(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserModel>(user);
        }
        public async Task<User> GetUserByEmail(string email)
        {
            var user = await _userRepository.GetByEmailAsync(email);
            return _mapper.Map<User>(user);
        }

        // only admins
        public async Task<List<UserModel>> GetAllUsers()
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<List<UserModel>>(users);
        }

    }
}
