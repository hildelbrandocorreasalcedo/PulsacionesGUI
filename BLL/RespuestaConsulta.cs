using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using ENTITY;

namespace BLL
{
     public class RespuestaConsulta
     {
           public string Mensaje { get; set; }
           public IList<Persona> Personas { get; set; }
           public bool Error { get; set; }
     }

     public class RespuestaBusqueda
     {
           public string Mensaje { get; set; }
           public Persona Persona { get; set; }
           public bool Error { get; set; }
     }
}

