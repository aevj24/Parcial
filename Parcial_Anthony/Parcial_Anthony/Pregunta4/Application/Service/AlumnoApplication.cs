using ConsoleAppParcial.Pregunta4.Application.Dto;
using ConsoleAppParcial.Pregunta4.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParcial.Pregunta4.Application.Service
{
    public class AlumnoApplication : BaseApplication
    {
        private readonly AlumnoRepository alumnoRepository;

        public AlumnoApplication(AlumnoRepository alumnoRepository) : base()
        {
            this.alumnoRepository = alumnoRepository;
        }

        public Object GetAlumnos(string carrera)
        {
            try
            {
   
                BaseResponseDto<AlumnoDto> baseResponseDto = new BaseResponseDto<AlumnoDto>();
                Notification notification = this.Validation(carrera);

                if (notification.HasErrors())
                {
                    return getApplicationErrorResponse(notification.Errors);
                }

                List<AlumnoDto> alumnosDto = new List<AlumnoDto>();
                alumnosDto = this.alumnoRepository.GetAlumnoDtosDto();

                if (alumnosDto == null)
                {
                    notification = new Notification();
                    notification.AddError("No hay Alumnos para mostrar");
                    return this.getApplicationErrorResponse(notification.Errors);
                }

                baseResponseDto.Data = alumnosDto;
                return alumnosDto;

            }
            catch (Exception ex )
            {
               throw ex;
            }
        }


        public Notification Validation(string carrera)
        {
            Notification notification = new Notification();

            if (carrera == "Derecho")
            {
                notification.AddError("No se pueden mostrar alumnos de esta carrera");
            }

            return notification;
        }

        public Notification ValidationDeuda(Decimal Deuda)
        {
            Notification notification = new Notification();

            if (Deuda > 0)
            {
                notification.AddError("No se pueden mostrar el alumno porque tiene deuda");
            }

            return notification;
        }



    }
}
