using System;
using Refit;
using reqrestRefitRazorA.Models;

namespace reqrestRefitRazorA.Services
{
	public interface IUserService
	{
		[Get("/users")]
		public Task<ResponseUser> getUsers();

        [Get("/users/{id}")]
        public Task<ResponseUserSingle> getUserById([AliasAs("id")] int id);

        [Post("/register")]
        public Task<Responsea> saveUser([Body] Usera usera);

        [Put("/users/{id}")]
        public Task<ResponseUpdateUser> updateUser([AliasAs("id")] int id, [Body] UserUpdate userUpdate);

        [Delete("/users/{id}")]
        public Task<string> deleteUser([AliasAs("id")] int id);
    }
}

