using ApiTarefas_Aula01.Classes;
using Microsoft.AspNetCore.Mvc;

namespace ApiTarefas_Aula01.Controllers
{
    [ApiController]
    [Route("tarefas")]
    [Tags("Rotas da Tarefa")]

    public class TarefaController : Controller
    {

        [HttpGet]
        public IActionResult ListarTarefas()
        {
            return Ok(ObterTarefas());
        }

        [HttpGet("usuario")]
        public IActionResult Usuario()
        {
            return Ok("Leyukezer Cruz");
        }


        [HttpPost]
        public IActionResult AdicionarTarefa([FromBody] Tarefa item)
        {
            var tarefa = new Tarefa();

            tarefa.Id_Tarefa = item.Id_Tarefa;
            tarefa.Descricao_Tarefa = item.Descricao_Tarefa;

            var lista_tarefa = ObterTarefas();

            lista_tarefa.Add(tarefa);

            return Ok(lista_tarefa);
        }

        public List<Tarefa> ObterTarefas()
        {
            List<Tarefa> lista = new List<Tarefa>() {

            new Tarefa { Id_Tarefa = 1, Descricao_Tarefa = "Estudo de ..." },
            new Tarefa { Id_Tarefa = 2, Descricao_Tarefa = "Estudo de ..." },
            new Tarefa { Id_Tarefa = 3, Descricao_Tarefa = "Estudo de ..." }
            };
            lista.Add(new Tarefa { Descricao_Tarefa = "PAUSA nos estudos" });

            return lista;
        }
    }
}
