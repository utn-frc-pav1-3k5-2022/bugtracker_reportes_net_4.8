﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    public class BugHistorico
    {

        public int IdBugHistorico { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        public DateTime FechaHistorico { get; set; }

        public Producto Producto { get; set; }

        public Prioridad Prioridad { get; set; }

        public Criticidad Criticidad { get; set; }

        public Estado Estado { get; set; }

        public Usuario UsuarioResponsable { get; set; }

        public Usuario UsuarioAsignado { get; set; }


    }
}
