using Microsoft.AspNetCore.Mvc;

namespace ApiTarefas_Aula01.Controllers
{
    [ApiController]
    [Route("tarefas")]

    public class TarefaController : Controller
    {
        [HttpGet]
        public IActionResult ListarTarefas()
        {

            return Ok(ObterTarefas());
        }

        private List<string> ObterTarefas() {
            List<string> tarefas = new List<string>() { "ESTUDAR", "DORMIR", "COMER", "SONECA"};

            tarefas.Add("Estudar - Metodos HTTPS");
            return tarefas;
        }
    }
}
