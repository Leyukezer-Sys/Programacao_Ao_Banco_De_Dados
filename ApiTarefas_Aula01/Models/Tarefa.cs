namespace ApiTarefas_Aula01.Models
{
    public class Tarefa
    {
        // Espelho do banco de dados
        public int Id { get; set; }
        public string? Descricao {  get; set; }
        public bool Feito { get; set; } = false;
        public DateTime Data { get; set; } = DateTime.Now;

    }
}
