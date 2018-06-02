using System.Collections.Generic;

namespace ConsoleAppParcial.Pregunta4.Application.Dto
{
    public class BaseResponseDto<T>
    {
        public List<T> Data { get; set; }
    }
}
