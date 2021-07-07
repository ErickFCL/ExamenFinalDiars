using ExFinalDiarsN00020449.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExFinalCalidadN00020449.Services
{
    public interface IClaimService
    {
        Usuario LoggedUser();
        void SetHttpContext(HttpContext httpContext);
    }
    public class ClaimService : IClaimService
    {
        private IN00020449Context context;
        private HttpContext httpContext;

        public ClaimService(IN00020449Context context)
        {
            this.context = context;

        }
        public void SetHttpContext(HttpContext httpContext)
        {
            this.httpContext = httpContext;
        }
        public Usuario LoggedUser()
        {
            var claim = httpContext.User.Claims.FirstOrDefault();

            var user = context.Usuarios.Where(o => o.Nombre == claim.Value).FirstOrDefault();
            return user;
        }
    }
}
