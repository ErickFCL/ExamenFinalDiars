﻿using ExFinalCalidadN00020449.Models;
using ExFinalCalidadN00020449.Services;
using ExFinalDiarsN00020449.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExFinalCalidadN00020449.Repositorio
{
    public interface INotaRepo
    {
        List<Usuario> GetUsuarios();
        List<Compartir> GetCompartir(int id);
       Compartir GetCompartir0(int idNota, int idUsuario, int idAmigo);
        List<Compartir> GetCompartir2();
        List<Etiqueta> GetEtiqueta();
        List<DetalleEtiquetaNota> GetDetalleEtiquetaNota();
        List<DetalleEtiquetaNota> GetDetalleEtiquetaNota2();
        List<DetalleEtiquetaNota> GetDetalleEtiquetaNota3(int idEtiqueta);
        List<Nota> GetNota();
        Nota GetNota2(int id);
        void saveNota(Nota nota);
        void UpdateNota(Nota nota);
        void saveDetEtiqNota(List<DetalleEtiquetaNota> etic);
        void saveCompartir(Compartir compartir);
        void DeleteNota(Nota nota, List<DetalleEtiquetaNota> etic);
    }
    public class NotaRepo : INotaRepo
    {
        private readonly IN00020449Context _context;
 
        public NotaRepo(N00020449Context _context) 
        {
            this._context = _context;
        }

        public void DeleteNota(Nota nota, List<DetalleEtiquetaNota> etic)
        {
            _context.Notas.Remove(nota);
            _context.DetalleEtiquetaNotas.RemoveRange(etic);
            _context.SaveChanges();
        }

        public List<Compartir> GetCompartir(int id)
        {
            return _context.Compartirs.Where(a => a.IdAmigo == id).Include(z => z.Notas).Include(z => z.Usuarios).ToList();
        }

        public Compartir GetCompartir0(int idNota, int idUsuario, int idAmigo)
        {
           return _context.Compartirs
                .Where(o => o.IdNota == idNota && o.IdUsuario == idUsuario).FirstOrDefault();
        }

        public List<Compartir> GetCompartir2()
        {
            return _context.Compartirs.Include(z => z.Notas).Include(z => z.Usuarios).ToList();
        }

        public List<DetalleEtiquetaNota> GetDetalleEtiquetaNota()
        {
            return _context.DetalleEtiquetaNotas.ToList();
        }

        public List<DetalleEtiquetaNota> GetDetalleEtiquetaNota2()
        {
            return _context.DetalleEtiquetaNotas.Include(o => o.Etiquetas).ToList();
        }

        public List<DetalleEtiquetaNota> GetDetalleEtiquetaNota3(int idEtiqueta)
        {
            return _context.DetalleEtiquetaNotas.Where(x => x.IdEtiqueta == idEtiqueta).
                Include(z => z.Notas).ToList();
        }

        public List<Etiqueta> GetEtiqueta()
        {
            return _context.Etiquetas.ToList();
        }

        public List<Nota> GetNota()
        {
            return _context.Notas.ToList();
        }

        public Nota GetNota2(int id)
        {
            return _context.Notas.Where(o => o.Id == id).FirstOrDefault();
        }

        public List<Usuario> GetUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public void saveCompartir(Compartir compartir)
        {
            _context.Compartirs.Add(compartir);
            _context.SaveChanges();
        }

        public void saveDetEtiqNota(List<DetalleEtiquetaNota> etic)
        {
            _context.DetalleEtiquetaNotas.AddRange(etic);
            _context.SaveChanges();
        }

        public void saveNota(Nota nota)
        {
            _context.Notas.Add(nota);
            _context.SaveChanges();
        }

        public void UpdateNota(Nota nota)
        {
            _context.Notas.Update(nota);
            _context.SaveChanges();
        }
    }
}
