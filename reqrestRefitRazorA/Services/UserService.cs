using System;
using Refit;
using reqrestRefitRazorA.Models;

namespace reqrestRefitRazorA.Services
{
	public class UserService: IUserService
	{
        private readonly IUserService _userService;
		public UserService(IUserService userService)
		{
            _userService = userService;

        }

        public async Task<string> deleteUser([AliasAs("id")] int id)
        {
            await _userService.deleteUser(id);
            return "OK";
        }

        public async Task<ResponseUserSingle> getUserById(int id)
        {
            var resp = await _userService.getUserById(id);
            return resp;
        }

        public async Task<ResponseUser> getUsers()
        {
            var resp = await _userService.getUsers();
            return resp;
        }

        public async Task<Responsea> saveUser([Body] Usera usera)
        {
            var resp = await _userService.saveUser(usera);
            return resp;
        }

        public async Task<ResponseUpdateUser> updateUser(int id, [Body] UserUpdate userUpdate)
        {
            var resp = await _userService.updateUser(id, userUpdate);
            return resp;
        }
    }
}

