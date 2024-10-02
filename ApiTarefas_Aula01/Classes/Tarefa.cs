using Microsoft.OpenApi.Services;

namespace ApiTarefas_Aula01.Classes
{
    public class Tarefa
    {
        public int Id_Tarefa { get; set; } = 0;
        public string? Descricao_Tarefa { get; set; }
        public DateTime Data_Criacao_Tarefa { get; set; } = DateTime.Now;
        public bool Finalizado_Tarefa { get; set; } = false;
        public DateTime? Data_Finalizado { get; set; }

    }
}
