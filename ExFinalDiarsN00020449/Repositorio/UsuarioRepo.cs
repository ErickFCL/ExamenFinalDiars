using ExFinalDiarsN00020449.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExFinalCalidadN00020449.Repositorio
{
    public interface IUsuarioRepo
    {
        Usuario GetUsuarios(string username, string password);
        string CreateHash(string password);
        void saveUser(Usuario usuario);
    }
    public class UsuarioRepo : IUsuarioRepo
    {
        private readonly IN00020449Context _context;
        private readonly IConfiguration configuration;
        public IHostEnvironment hostEnv;
        public UsuarioRepo(IN00020449Context _context, IConfiguration configuration, IHostEnvironment hostEnv)
        {
            this._context = _context;
            this.configuration = configuration;
            this.hostEnv = hostEnv;
        }

        public Usuario GetUsuarios(string username, string password)
        {
            return _context.Usuarios.Where(o => o.Nombre == username && o.Password == CreateHash(password))
                .FirstOrDefault();

        }

        public void saveUser(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        string CreateHash(string input)
        {
            var sha = SHA256.Create();
            input += configuration.GetValue<string>("Token");
            var hash = sha.ComputeHash(Encoding.Default.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        string IUsuarioRepo.CreateHash(string password)
        {
            var sha = SHA256.Create();
            password += configuration.GetValue<string>("Token");
            var hash = sha.ComputeHash(Encoding.Default.GetBytes(password));

            return Convert.ToBase64String(hash);
        }
    }
   
}
