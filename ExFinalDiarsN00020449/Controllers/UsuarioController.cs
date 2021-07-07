using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ExFinalCalidadN00020449.Repositorio;
using ExFinalCalidadN00020449.Services;
using ExFinalDiarsN00020449.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ExFinalDiarsN00020449.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepo context;
        private readonly IClaimService claim;
      

        public UsuarioController(IUsuarioRepo context, IClaimService claim)
        {
            this.context = context;
           
            this.claim = claim;
            claim.SetHttpContext(HttpContext);
        }

        [HttpGet]
        public ActionResult Login()
        {
            claim.SetHttpContext(HttpContext);
            return View("Login");
        }
        [HttpPost]
        public ActionResult Login(string NombreUsuario, string Password)
        {
            claim.SetHttpContext(HttpContext);
            var usuario = context.GetUsuarios(NombreUsuario, Password);
                
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
            return View("Login");
        }
        [HttpGet]
        public ActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return View("Login");
        }
       
        [HttpGet]
        public ActionResult Create()
        {
            claim.SetHttpContext(HttpContext);
            return View("Create");
        }
        [HttpPost]
        public ActionResult Create(Usuario usuario, string password, string passwordpok)
        {
            claim.SetHttpContext(HttpContext);
            if (password != passwordpok) // <-- para convalidar contraseña y confirmacion de contraseña
                ModelState.AddModelError("Passwordpok", "Las contraseñas no coinciden");

            if (ModelState.IsValid)
            {
                usuario.Password = context.CreateHash(password);

                context.saveUser(usuario);
                return RedirectToAction("Login");
            }
            return View("Create", usuario);
        }
        
    }
}
