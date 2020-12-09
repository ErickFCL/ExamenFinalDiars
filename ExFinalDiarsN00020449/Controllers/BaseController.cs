using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExFinalDiarsN00020449.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExFinalDiarsN00020449.Controllers
{
    public class BaseController : Controller
    {
        private readonly N00020449Context context;
        public BaseController(N00020449Context context)
        {
            this.context = context;
        }

        protected Usuario LoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = context.Usuarios.Where(o => o.Nombre == claim.Value).FirstOrDefault();
            return user;
        }
    }
}
