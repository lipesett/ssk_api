using ApiSSK.Models.Enums;

public partial class MelhorVoltaModel
{
    public int Id { get; set; }
    public string? Tempo { get; set; }
    public int? MelhorVoltaDescId { get; set; }
    public int? PilotoId { get; set; }
    public int? CalendarioId { get; set; }
    public EClima Clima { get; set; }
    
    public virtual MelhorVoltaDescModel? MelhorVoltaDesc { get; set; }
    public virtual PilotoModel? Piloto { get; set; }
    public virtual CalendarioModel? Calendario { get; set; }
}
