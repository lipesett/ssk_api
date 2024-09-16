public partial class MelhorVoltaModel
{
    public int MvId { get; set; }
    public string MvTempo { get; set; } = null!;
    public int? MelhorVoltaDescId { get; set; }
    public int PilotoId { get; set; }
    public int? ClimaId { get; set; }
    public int? CalendarioId { get; set; }

    public virtual MelhorVoltaDescModel MelhorVoltaDesc { get; set; }
    public virtual PilotoModel Piloto { get; set; }
    public virtual ClimaModel? Clima { get; set; }
    public virtual CalendarioModel? Calendario { get; set; }
}
