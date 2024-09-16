using System.Globalization;

public partial class MelhorVoltaModel
{
    public int MvId { get; set; }
    public string MvTempo { get; set; } = null!;
    public string? MvTipo { get; set; }
    public int PilMv { get; set; }
    public int? CliClima { get; set; }
    public int? CalNumeroEtapa { get; set; }

    public virtual PilotoModel Piloto { get; set; } = null!;
    public virtual ClimaModel? Clima { get; set; }
    public virtual CalendarioModel? Calendario { get; set; }
}
