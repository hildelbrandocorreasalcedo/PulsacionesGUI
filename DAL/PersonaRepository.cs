using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.IO;

namespace DAL
{
    public class PersonaRepository
    {

        private string ruta = @"personas.txt";
        public IList<Persona> personas;

        public PersonaRepository(){
            personas = new List<Persona>();
           }
         public void Guardar(Persona persona) {
            FileStream fileStream = new FileStream(ruta, FileMode.Append);
            StreamWriter stream = new StreamWriter(fileStream);
            stream.WriteLine(persona.ToString());
            stream.Close();
            fileStream.Close();
         }
        public IList<Persona> Consultar() {
            personas.Clear();
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(fileStream);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
               Persona persona = MapearPersona(linea);
               personas.Add(persona);
            }
            lector.Close();
            fileStream.Close();
            return personas;
         }
        public Persona MapearPersona(string linea)
        {
            Persona persona = new Persona();
            string[] datos = linea.Split(';');
            persona.Identificacion = datos[0];
            persona.Nombre = datos[1];
            persona.Edad = int.Parse(datos[2]);
            persona.Sexo = datos[3];
            persona.Calcularpulsaciones();
            return persona;
        }


        public void Eliminar(string identificacion)
        {
            personas.Clear();
            personas = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in personas)
            {
                if (item.Identificacion != identificacion)
                {
                    Guardar(item);
                }
            }
        }

        public void Modificar(Persona persona)
        {
            personas.Clear();
            personas = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in personas)
            {
                if (item.Identificacion != persona.Identificacion)
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(persona);
                }
            }

        }
        public Persona Buscar(string identificacion)
        {
            personas.Clear();
            personas = Consultar();
            Persona persona = new Persona();
            foreach (var item in personas)
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    return item;
                }
            }
            return null;
        }

        public int TotalizarPersonas()
        {
            return personas.Count();
        }

        public int TotalizarMujeres()
        {
            return personas.Where(p => p.Sexo == "F").Count();
        }

        public int TotalizarHombres()
        {
            return personas.Where(p => p.Sexo=="M").Count();
        }
        
        public IList<Persona> ListaHombres()
        {
            return personas.Where(p => p.Sexo=="M").ToList() ;
        }
        public IList<Persona> Listamujeres()
        {
            return personas.Where(p => p.Sexo == "F").ToList();
        }




    }

   


}
