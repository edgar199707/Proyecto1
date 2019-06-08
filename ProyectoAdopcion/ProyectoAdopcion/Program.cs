using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAdopcion
{
    class Program: Adopcion
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Animal animal = new Animal();
            string respuesta;

            Console.WriteLine("¿Cúal es tu nombre?");
            persona.nombre = Console.ReadLine();
            Console.WriteLine("¿Que animal buscas ?");
            animal.tipo = Console.ReadLine();
            Console.WriteLine("Buscas adoptar? Si/No");
            respuesta = Console.ReadLine();
            Adopcion adopcion = new Adopcion(animal, persona);
        }
    }
}
