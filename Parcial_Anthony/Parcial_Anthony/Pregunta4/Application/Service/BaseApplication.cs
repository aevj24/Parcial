using ConsoleAppParcial.Pregunta4.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParcial.Pregunta4.Application.Service
{
    public class BaseApplication
    {
        public BaseApplication()
        {
        }

        public BaseErrorResponseDto getExceptionErrorResponse()
        {
            BaseErrorDto error = new BaseErrorDto(500, "Failed Request", 321);
            List<BaseErrorDto> errors = new List<BaseErrorDto>();
            errors.Add(error);
            BaseErrorResponseDto response = new BaseErrorResponseDto();
            response.Errors = errors;
            return response;
        }

        public BaseErrorResponseDto getApplicationErrorResponse(List<Error> errors)
        {
            BaseErrorResponseDto response = new BaseErrorResponseDto();
            List<BaseErrorDto> responseErrors = new List<BaseErrorDto>();
            foreach (Error error in errors)
            {
                responseErrors.Add(new BaseErrorDto(400, error.Message, 123));
            }
            response.Errors = responseErrors;
            return response;
        }

        public int ForceException()
        {
            int a = 5;
            int b = 0;
            return a / b;
        }
    
}
}
