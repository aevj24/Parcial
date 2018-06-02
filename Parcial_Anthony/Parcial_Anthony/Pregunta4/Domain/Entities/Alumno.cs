using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParcial.Pregunta4.Domain.Entities
{
    public class Alumno
    {
        public long Id { get; set; }
        public string Nombre;
        public Carrera carrera;
        public Decimal deuda;

        public Alumno()
        {

        }

        public Alumno(long id, string nombre, Carrera carrera, Decimal deuda)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.carrera = carrera;
            this.deuda = deuda;
        }
    }
}
