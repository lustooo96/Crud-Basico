using Microsoft.AspNetCore.Mvc;

namespace CrudBascio.WebApi.Exce
{
    public class ExceptionHandling : ProblemDetails
    {
        public string AdditionalDetails { get; set; }
    }
}
