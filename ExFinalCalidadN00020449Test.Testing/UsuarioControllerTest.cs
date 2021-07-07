using ExFinalCalidadN00020449.Repositorio;
using ExFinalCalidadN00020449.Services;
using ExFinalDiarsN00020449.Controllers;
using ExFinalDiarsN00020449.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExFinalCalidadN00020449Test.Testing
{
    [TestFixture]
    public class UsuarioControllerTest
    {
        [Test]
        public void InSessionGet()
        {

            var claim = new Mock<IClaimService>();
            claim.Setup(s => s.LoggedUser()).Returns(new Usuario());
            var repository = new Mock<IUsuarioRepo>();

            var controller = new UsuarioController(repository.Object, claim.Object);
            var view = controller.Login() as ViewResult;

            Assert.AreEqual("Login", view.ViewName);
        }
        [Test]
        public void InSessionPost()
        {
            var claim = new Mock<IClaimService>();
            var repository = new Mock<IUsuarioRepo>();
            var controller = new UsuarioController(repository.Object, claim.Object);
            var view = controller.Login("llico", "Aa1234") as ViewResult;
            Assert.AreEqual("Login", view.ViewName);

        }
        [Test]
        public void CreateGet()
        {
            var claim = new Mock<IClaimService>();
            var repository = new Mock<IUsuarioRepo>();
            var controller = new UsuarioController(repository.Object, claim.Object);
            var view = controller.Create() as ViewResult;
            Assert.AreEqual("Create", view.ViewName);
        }

        [Test]
        public void CrearPost()
        {
            var claim = new Mock<IClaimService>();
            claim.Setup(s => s.LoggedUser()).Returns(new Usuario());
            var repository = new Mock<IUsuarioRepo>();
            var controller = new UsuarioController(repository.Object, claim.Object);
            var view = controller.Create(new Usuario { }, "Aa1234", "Aa1234") as RedirectToActionResult;
            Assert.AreEqual("Login", view.ActionName);
        }
     
    }
}
