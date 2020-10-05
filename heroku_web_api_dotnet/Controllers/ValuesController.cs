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
            return Content("{\"cabecalho\":{\"instituicao\":\"JED - Jurisdicción Especial para el Desarollo\",\"emissao\":\"Emitido em: 31/10/2019 09:04:04\",\"total\":\"Total\",\"titulo\":\"Informe del Consumo de Archivos por la Relatoría de la JED\",\"pagina\":\"Página\",\"vara\":\"Órgano judicial\",\"foro\":\"Complejo judicial\",\"juiz\":\"Nombre del magistrado\",\"nome_documento\":\"Nombre del archivo\",\"data\":\"Fecha y hora del consumo\",\"parametros\":\"Parâmetros do relatório\",\"consumido\":\"consumido\",      \"ordem\":\"Orden\",\"filtros\": [   {      \"rotulo\": \"Órgano judicial\",      \"descricao\": \"Sala de Desarrollo de Software\"   },   {      \"rotulo\": \"Magistrado\",      \"descricao\": \"Jerónimo González\"   },   {      \"rotulo\": \"Fecha inicial y final de consumo\",      \"descricao\": \"01/01/2020 à 20/01/2020\"   },   {      \"rotulo\": \"Situación\",      \"descricao\": \"Todos\"   }]},\"metadados\":[{   \"nome_documento\":\"Archivo 1\",   \"foro\":\"Jurisdicción Especial para La Paz\",   \"vara\":\"Sala de Desarrollo de Software\",   \"juiz\":\"Jerónimo González\",   \"data\":\"\"},{   \"nome_documento\":\"Archivo 2\",   \"foro\":\"Jurisdicción Especial para La Paz\",   \"vara\":\"Sala de Desarrollo de Software\",   \"juiz\":\"Jerónimo González\",   \"data\":\"29/09/2020 2:00 AM\"},{   \"nome_documento\":\"Archivo 3\",   \"foro\":\"Jurisdicción Especial para La Paz\",   \"vara\":\"Sala de Desarrollo de Software\",   \"juiz\":\"Jerónimo González\",   \"data\":\"30/09/2020 3:00 AM\"}]}", "application/json");
        }
    }
}
