using Microsoft.AspNetCore.Mvc;

namespace heroku_web_api_dotnet.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Content("{\"cabecalho\":{\"instituicao\":\"JEP - Jurisdicción Especial para la Prueba\",\"emissao\":\"Emitido el: 31/10/2019 09:04:04\",\"titulo\":\"Informe reparto por período\",\"pagina\":\"Página\",\"vara\":\"Órgano judicial\",\"magistrado\":\"Magistrado\",\"data\":\"Fecha del reparto\",\"processo\": \"Proceso\",\"classe\": \"Clase\",\"assunto\": \"Asunto\",  \"parametros\":\"Parámetros del informe\",\"filtros\":[{\"rotulo\":\"Órgano judicial\",\"descricao\":\"Sala X\"},{\"rotulo\":\"Magistrado\",\"descricao\":\"Magistrado X\"},{\"rotulo\":\"Fecha del reparto\",\"descricao\":\"01/01/2020 hasta 20/01/2020\"},{\"rotulo\":\"Proceso\",\"descricao\":\"00000000123456789\"},{\"rotulo\":\"Solo último reparto\",  \"descricao\":\"No\"}]},\"metadados\":[{\"processo\":\"00000000123456789\",\"classe\":\"Clase X \",\"assunto\":\"Asunto Y\",\"data\":\"30/09/2020 3:00 AM\",\"vara\": \"Sala X\",\"magistrado\":\"Magistrado X\"}]}", "application/json");
        }
    }
}
