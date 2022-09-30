using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoNovedades.Net
{
    public  class TiposReferenciaNullables

    {
        public int Suma2(int n)
        {
            n = n + 2;
            return n;
        }
        public void CambiaNombre(Persona per)
        {
            per.Nombre = per.Nombre + " CAMBIADO";
        }

    }
    public class Persona
    {
        public string Nombre;
        public string Apellidos;
        public int Edad;
    }
}
