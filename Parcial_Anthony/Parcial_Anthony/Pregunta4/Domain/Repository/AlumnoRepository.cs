using ConsoleAppParcial.Pregunta4.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParcial.Pregunta4.Domain.Repository
{
    public interface AlumnoRepository
    {
        AlumnoDto AlumnoDto(long id);
        List<AlumnoDto> GetAlumnoDtosDto();
    }
}
