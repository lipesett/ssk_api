using System.ComponentModel;

namespace ApiSSK.Models.Enums;

public enum EStatus
{
    [Description("Ativo")]
    ATIVO = 1,
    
    [Description("Inativo")]
    INATIVO,
    
    [Description("Pendente")]
    PENDENTE,
    
    [Description("Concluido")]
    CONCLUIDO,
    
    [Description("Cancelado")]
    CANCELADO,
}