﻿using System;
using System.Collections.Generic;

namespace ComputadorasEYCD110324.Models
{
    public partial class Componente
    {
        public int Id { get; set; }
        public int? IdComputadoras { get; set; }
        public string? Procesador { get; set; }
        public int? MemoriaRamgb { get; set; }
        public int? AlmacenamientoGb { get; set; }

        public virtual Computadora? IdComputadorasNavigation { get; set; }
    }
}
