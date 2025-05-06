using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class Acciones : IAcciones
    {
        Alumno a=new Alumno();
        private List<Alumno> listalumnos = new List<Alumno>()
        {new Alumno("Ana",21,112609),
        new Alumno("Araceli",20,115690)};
        public void Actualizar(int matricula, string nombre, int edad)
        {
            var alumno = listalumnos.FirstOrDefault(x => x.Matricula == matricula);
            if (alumno != null)
            {
                alumno.Nombre = nombre;
                alumno.Edad = edad;
                Console.WriteLine("Alumno actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("Alumno no encontrado.");
            }

        }

        public void Agregar(int matricula, string nombre, int edad)
        {
            listalumnos.Add(new Alumno(a.Nombre,a.Edad,a.Matricula));
        }

        public List<Alumno> Consultar()
        {
            return listalumnos;
        }

        public void Eliminar(int matricula)
        {
            var objetoeliminar = listalumnos.FirstOrDefault(x=>x.Matricula==matricula);
            if (objetoeliminar != null)
                listalumnos.Remove(objetoeliminar);
            else
                Console.WriteLine("No se pudo eliminar");
        }

        public void ExportaraExcel()
        {
            throw new NotImplementedException();
        }
    }
}
