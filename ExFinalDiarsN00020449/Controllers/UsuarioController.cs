using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ExFinalDiarsN00020449.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ExFinalDiarsN00020449.Controllers
{
    public class UsuarioController : BaseController
    {
        private readonly N00020449Context context;
        private readonly IConfiguration configuration;
        public IHostEnvironment hostEnv;

        public UsuarioController(N00020449Context context, IHostEnvironment hostEnv, IConfiguration configuration) : base(context)
        {
            this.context = context;
            this.configuration = configuration;
            this.hostEnv = hostEnv;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }
        [HttpPost]
        public ActionResult Login(string NombreUsuario, string Password)
        {
            var usuario = context.Usuarios
                .Where(o => o.Nombre == NombreUsuario && o.Password == CreateHash(Password))
                .FirstOrDefault();

            if (usuario != null)
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, NombreUsuario)
                };

                var claimsIdentity = new ClaimsIdentity(claims, "Login");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                HttpContext.SignInAsync(claimsPrincipal);

                return RedirectToAction("Index", "Nota");
            }

            ModelState.AddModelError("Login", "Usuario o contraseña incorrectos.");
            return View();
        }
        [HttpGet]
        public ActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return View("Login");
        }
        private string CreateHash(string input)
        {
            var sha = SHA256.Create();
            input += configuration.GetValue<string>("Token");
            var hash = sha.ComputeHash(Encoding.Default.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Usuario usuario, string password, string passwordpok)
        {
            if (password != passwordpok) // <-- para convalidar contraseña y confirmacion de contraseña
                ModelState.AddModelError("Passwordpok", "Las contraseñas no coinciden");

            if (ModelState.IsValid)
            {
                usuario.Password = CreateHash(password);
                context.Usuarios.Add(usuario);
                context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View("Create", usuario);
        }
        
    }
}
