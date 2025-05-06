using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class Program
    {
        public enum Menu
        {
            Consultar=1,Agregar,Actualizar,Eliminar
        }
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();
            while (true)
            {
                switch (menu())
                {
                    case Menu.Consultar:
                        var lista = acciones.Consultar();
                        foreach (var l in lista)
                        {
                            Console.WriteLine("-------------------------");
                            Console.WriteLine($"Nombre: {l.Nombre}");
                            Console.WriteLine($"Edad: {l.Edad}");
                            Console.WriteLine($"Matricula: {l.Matricula}");
                            Console.WriteLine("-------------------------");
                        }
                        break;
                    case Menu.Agregar:
                        Console.WriteLine("Dame el nombre");
                        string nombre=Console.ReadLine();
                        Console.WriteLine("Dame la edad");
                        int edad=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dame la matricula");
                        int matricula=Convert.ToInt32(Console.ReadLine());
                        acciones.Agregar(matricula, nombre, edad);
                        break;
                    case Menu.Actualizar:
                        Console.WriteLine("Dame la matrícula del alumno a actualizar:");
                        int matActualizar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Nuevo nombre:");
                        string nuevoNombre = Console.ReadLine();

                        Console.WriteLine("Nueva edad:");
                        int nuevaEdad = Convert.ToInt32(Console.ReadLine());

                        acciones.Actualizar(matActualizar, nuevoNombre, nuevaEdad);

                        break;
                    case Menu.Eliminar:
                        break;
                    default:
                        break;
                }
            }
        }
        static Menu menu()
        {
            Console.WriteLine("1.Consultar");
            Console.WriteLine("2.Agregar");
            Console.WriteLine("3. Actualizar");
            Console.WriteLine("4.Eliminar");
            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
