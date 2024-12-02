using System.ComponentModel;

namespace ApiSSK.Models.Enums;

public enum ESentido
{
    [Description("Horário")]
    HORARIO = 1,
    
    [Description("Anti-Horário")]
    ANTI_HORARIO
}