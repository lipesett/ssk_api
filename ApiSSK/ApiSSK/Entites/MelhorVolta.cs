using System.Globalization;

public partial class MelhorVolta
{
    public int MvId { get; set; }
    public string MvTempo { get; set; } = null!;
    public string? MvTipo { get; set; }
    public int PilMv { get; set; }
    public int? CliClima { get; set; }
    public int? CalNumeroEtapa { get; set; }

    public virtual Piloto Piloto { get; set; } = null!;
    public virtual Clima? Clima { get; set; }
    public virtual Calendario? Calendario { get; set; }
}
