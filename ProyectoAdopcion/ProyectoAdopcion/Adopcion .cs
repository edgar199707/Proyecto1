using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAdopcion
{
    class Adopcion :Persona
    {
        public Adopcion() { }
        public Adopcion(Animal animal, Persona persona) { adoptar(animal, persona); }
        public void adoptar(Animal animal, Persona persona)
        {
            Console.WriteLine("Buen dia: " + persona.nombre + "\nHoy adoptaste a un: " + animal.tipo);
            Console.WriteLine("Saludos.");
            Console.ReadLine();
        }
    }
}
