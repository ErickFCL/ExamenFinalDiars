using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExFinalDiarsN00020449.Models
{
    public class DetalleEtiquetaNota
    {
        public int Id { get; set; }
        public int IdEtiqueta { get; set; }
        public int IdNota { get; set; }
        public Etiqueta Etiquetas { get; set; }
        public Nota Notas { get; set; }

    }
}
