using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Persona
    {
        public string Identificacion;
        public string Nombre;
        public int Edad;
        public string Sexo;
        public decimal Pulsacion;

        public void Calcularpulsaciones() {
            if (Sexo.ToUpper() == "F")
            {
                Pulsacion = (220 - Edad) / 10;
            }
            else if (Sexo.ToUpper() == "M")
            {
                Pulsacion = (210 - Edad) / 10;
            }
            else
            {
                Pulsacion = 0;
            }


        }

        public override string ToString()
        {
            return $"{Identificacion};{Nombre};{Edad};{Sexo};{Pulsacion}";

}



    }
}
