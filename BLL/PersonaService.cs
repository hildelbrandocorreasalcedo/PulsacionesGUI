using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class PersonaService
    {
        public PersonaRepository personaRepositorio;
       
        public PersonaService()
        {
            personaRepositorio = new PersonaRepository();
        }

        public string Guardar(Persona persona)
        {
            try
            {
                if (personaRepositorio.Buscar(persona.Identificacion) == null)
                {

                    personaRepositorio.Guardar(persona);
                    return "Los Datos han sido guardados satisfactoriamente";
                }
                return $"La identificacion {persona.Identificacion} ya se encuentra registrada por favor verifique los datos";
            }
            catch (Exception e)
            {
                return "Error de Datos: " + e.Message;
            }
        }

        public string Eliminar(string identificacion)
        {
            try
            {
                if (personaRepositorio.Buscar(identificacion) != null)
                {
                    personaRepositorio.Eliminar(identificacion);
                    return $"Los Persona con identificacion {identificacion} ha sido eliminada satisfacatoriamente";
                }
                return $"La identificacion {identificacion} no se encuentra registrada por favor verifique los datos";
            }
            catch (Exception e)
            {

                return "Error de datos" + e.Message;
            }
        }
        public string Modificar(Persona persona)
        {
            try
            {
                if (personaRepositorio.Buscar(persona.Identificacion) != null)
                {

                    personaRepositorio.Modificar(persona);
                    return $"Los Persona con identificacion {persona.Identificacion} ha sido modificada satisfacatoriamente";
                }
                return $"La identificacion {persona.Identificacion} no se encuentra registrada por favor verifique los datos";
            }
            catch (Exception e)
            {
                return "Error de datos" + e.Message;
            }
        }

        public RespuestaBusqueda Buscar(string Identificacion)
        {
            RespuestaBusqueda respuesta = new RespuestaBusqueda();
            try
            {
                respuesta.Error = false;
                Persona persona = personaRepositorio.Buscar(Identificacion);
                if (persona == null)
                {
                    respuesta.Mensaje = $"La persona con cédula numero {Identificacion} no se encuentra registrada";
                    respuesta.Persona = null;
                }
                else
                {
                    respuesta.Persona = persona;
                    respuesta.Mensaje = "Persona encontrada\n\n";
                }
            }
            catch (Exception E)
            {
                respuesta.Mensaje = "Error de lectura o escritura de archivos: " + E.Message;
                respuesta.Persona = null;
                respuesta.Error = true;
            }
            return respuesta;
        }

        public RespuestaConsulta Consultar()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {
                respuesta.Error = false;
                IList<Persona> Personas = personaRepositorio.Consultar();
                if (Personas.Count != 0)
                {
                    respuesta.Mensaje = "Se Consulta la Informacion de personas";
                    respuesta.Personas = Personas;
                }
                else
                {
                    respuesta.Mensaje = "No existen Datos para Consultar";
                    respuesta.Personas = null;
                }
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = $"Erro en datos: " + e.Message;
                respuesta.Personas = null;
            }
            return respuesta;
        }

        public  int TotalizarPersonas()
        {
            return personaRepositorio.TotalizarPersonas();
        }

        public  int TotalizarMujeres()
        {
            return personaRepositorio.TotalizarMujeres();
        }

        public  int TotalizarHombres()
        {
            return personaRepositorio.TotalizarHombres();
        }

        public IList<Persona> ListaHombres()
        {
            return personaRepositorio.ListaHombres();
        }


        public IList<Persona> ListaMujeres()
        {
            return personaRepositorio.Listamujeres();
        }

      }

    
    

    
}

