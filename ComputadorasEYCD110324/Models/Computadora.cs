using System;
using System.Collections.Generic;

namespace ComputadorasEYCD110324.Models
{
    public partial class Computadora
    {
        public Computadora()
        {
            Componentes = new HashSet<Componente>();
        }

        public int Id { get; set; }
        public DateTime? FechaLlegada { get; set; }
        public string? Marca { get; set; }
        public string? Tipo { get; set; }

        public virtual ICollection<Componente> Componentes { get; set; }
    }
}
