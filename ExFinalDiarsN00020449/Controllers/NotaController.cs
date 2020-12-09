using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExFinalDiarsN00020449.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExFinalDiarsN00020449.Controllers
{
    [Authorize]
    public class NotaController : Controller
    {
        List<DetalleEtiquetaNota> etic = new List<DetalleEtiquetaNota>();
        private readonly N00020449Context context;
        public NotaController(N00020449Context context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Etiquetas = context.Etiquetas.ToList();
            ViewBag.Etiquetitas = context.DetalleEtiquetaNotas.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult _Index(string search)
        {
            var notas = context.Notas.ToList();
            
            /*var Buscador = context.DetalleEtiquetaNotas.Include(a=>a.Etiquetas).
                Include(s=>s.Notas).
                ToList();*/

            ViewBag.Etiquetas = context.Etiquetas.ToList();
            ViewBag.Etiquetitas = context.DetalleEtiquetaNotas.ToList();

            if (!String.IsNullOrEmpty(search))
            {
                notas = notas.Where(o => o.Titulo.Contains(search) || o.Contenido.Contains(search)).ToList();
                //Buscador = Buscador.Where(o => o.Notas.Titulo.Contains(search) || o.Notas.Contenido.Contains(search) || o.Etiquetas.Nombre.Contains(search)).ToList();

                return View(notas);
            }
            return View(notas);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Etiquetas = context.Etiquetas.ToList();
            return View(new Nota());
        }
        [HttpPost]
        public IActionResult Create(Nota nota, List<int> etiqueta)
        {
            List<DetalleEtiquetaNota> etic = new List<DetalleEtiquetaNota>();

            if (etiqueta.Count() == 0)
                ModelState.AddModelError("etiqueta", "Seleccione por lo menos uno");
            if (nota.Titulo == null)
                ModelState.AddModelError("titulo", "Campo requerido");
            if (nota.Contenido == null)
                ModelState.AddModelError("contenido", "Campo requerido");

            nota.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                context.Notas.Add(nota);
                context.SaveChanges();
                foreach (var item in etiqueta)
                {
                    var etique = new DetalleEtiquetaNota();
                    etique.IdEtiqueta = item;
                    etique.IdNota = nota.Id;
                    etic.Add(etique);
                }
                context.DetalleEtiquetaNotas.AddRange(etic);
                context.SaveChanges();
                
                return RedirectToAction("Index");
            }
            else
            {
                Response.StatusCode = 400;
                ViewBag.Etiquetas = context.Etiquetas.ToList();
                return View(nota);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Etiquetas = context.Etiquetas.ToList();
            var nota = context.Notas.Where(o => o.Id == id).FirstOrDefault();
            return View(nota);
        }
        [HttpPost]
        [HttpPost]
        public IActionResult Edit(Nota nota/*, List<int> etiqueta*/)
        {
            nota.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                context.Notas.Update(nota);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                Response.StatusCode = 400;
                ViewBag.Etiquetas = context.Etiquetas.ToList();
                return View(nota);
            }
        }

        [HttpGet]
        public IActionResult Detalle(int id)
        {

            var etiqueta = context.Etiquetas.ToList();
            ViewBag.Etiquetas = context.DetalleEtiquetaNotas.Include(o => o.Etiquetas).ToList();
            var nota = context.Notas.Where(o => o.Id == id).FirstOrDefault();
            return View(nota);
        }
        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            var nota = context.Notas.Where(o => o.Id == id).FirstOrDefault();
            var etiqueta = context.DetalleEtiquetaNotas.Where(o => o.IdNota == id).ToList();
            context.Notas.Remove(nota);
            context.DetalleEtiquetaNotas.RemoveRange(etiqueta);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Lista(int idEtiqueta, string titulo)
        {
            ViewBag.DetalleEtiquetaNota = context.DetalleEtiquetaNotas.Where(x=>x.IdEtiqueta == idEtiqueta).
                Include(z => z.Notas).ToList();

            ViewBag.Titulo = titulo;

            return View();
        }
    }
}
