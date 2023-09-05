using System.ComponentModel;

namespace Tarefas.Enum
{
    public enum StatusEnum
    {
        [Description("A Fazer")]
        AFazer = 1,
        [Description("Em Andamento")]
        EmAndamento=2,
        [Description("Concluido")]
        Concluido = 3
    }
}
