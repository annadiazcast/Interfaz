using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class Alumno:Persona
    {
        public Alumno(string nombre, int edad,int matricula)
            :base(nombre,edad)
        {
            Matricula = matricula;
        }
        public Alumno() { }

        public int Matricula { get; set; }
    }
}
