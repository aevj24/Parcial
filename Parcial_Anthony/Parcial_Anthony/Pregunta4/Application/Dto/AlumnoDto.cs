using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParcial.Pregunta4.Application.Dto
{
    public class AlumnoDto
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public Decimal deuda { get; set; } 

        public AlumnoDto()
        {
        }

        public AlumnoDto(long id, String nombre, String carrera, Decimal deuda)
        {
            Id = id;
            Nombre = nombre;
            Carrera = carrera;
            this.deuda = deuda;
        }
    }
}
