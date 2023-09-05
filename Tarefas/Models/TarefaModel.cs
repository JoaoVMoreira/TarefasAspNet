using Tarefas.Enum;

namespace Tarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public StatusEnum Status { get; set; }
    }
}
