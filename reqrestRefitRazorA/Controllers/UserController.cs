using System;
using System.Numerics;
using Microsoft.AspNetCore.Mvc;
using reqrestRefitRazorA.Services;
using reqrestRefitRazorA.Models;
using Microsoft.AspNetCore.Authorization;
using Refit;
using Newtonsoft.Json;

namespace reqrestRefitRazorA.Controllers
{
	public class UserController: Controller
	{
		private readonly IUserService _userService;
		public UserController(IUserService userService)
        {
			_userService = userService;
		}

        public async Task<IActionResult> Index()
        {
            //Task<ResponseUser> resp;
            try

            {
                List<Data> dat = new List<Data>();
                var resp = await _userService.getUsers();
                return View(resp.data);
            }
            catch(Exception e)
            {
                System.Console.WriteLine($"The file was not found: '{e}'");
                return View();
            }

            //return View(resp);

        }


        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var resp = await _userService.getUserById(id);
                TempData["data"] = JsonConvert.SerializeObject(resp);
                return View();
            }
            catch (ApiException e)
            {
                TempData["error"] = "Error al traer usuario";
                return View();
            }

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("email,password")] Usera usera)
        {
            try { 
                if (usera == null)
                {
                    return View(usera);
                }
                var resp = await _userService.saveUser(usera);
                TempData["Ok"] = "Usuario Guardado satisfactoriamente";
                return View();
            }
            catch(ApiException e)
            {
                TempData["Error"] = "Error al guardar usuario";
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Details([Bind("id,name,job")] UserUpdate usera)
        {
            try
            {
                if (usera == null)
                {
                    return View(usera);
                }
                var resp = await _userService.updateUser(usera.id, usera);
                TempData["Ok"] = "Usuario Guardado satisfactoriamente"+ resp.updatedAt;
                return View();
            }
            catch (ApiException e)
            {
                TempData["Error"] = "Error al actualizar usuario";
                return View();
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var resp = await _userService.getUserById(id);
                //TempData["data"] = JsonConvert.SerializeObject(resp);
                return View(resp.data);
            }
            catch (ApiException e)
            {
                TempData["error"] = "Error al traer usuario";
                return View();
            }
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            TempData["ok"] = "Usuario eliminado satisfactoriamente";
            await _userService.deleteUser(id);
            return View();
        }



    }
}

