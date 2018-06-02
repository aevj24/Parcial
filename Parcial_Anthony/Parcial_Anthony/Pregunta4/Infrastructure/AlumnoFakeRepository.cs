using ConsoleAppParcial.Pregunta4.Application.Dto;
using ConsoleAppParcial.Pregunta4.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParcial.Pregunta4.Infrastructure
{
    public class AlumnoFakeRepository : AlumnoRepository
    {
        public AlumnoDto AlumnoDto(long id)
        {
            throw new NotImplementedException();
        }

        public List<AlumnoDto> GetAlumnoDtosDto()
        {
            List<AlumnoDto> alumnoList = new List<AlumnoDto>
            {
                new AlumnoDto(1, "Anthony Vargas", "Ingeniería de Sistemas",0),
                new AlumnoDto(2, "Raul Valle", "Ciencias de la comunicación.",500),
                new AlumnoDto(1, "Aaron Vargas", "Ingeniería de Sistemas",0),
                new AlumnoDto(1, "Pamela Vargas", "Derecho",0),
            };
            return alumnoList;
        }
    }
}
