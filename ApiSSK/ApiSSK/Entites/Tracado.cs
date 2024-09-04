public partial class Tracado
{
    public int TraId { get; set; }
    public string TraNome { get; set; } = null!;
    public DateTime TraDataEstreia { get; set; }
    public int KarKartodromo { get; set; }
    public int? SenSentido { get; set; }
    public int? CliClima { get; set; }
    public int? MvEstreiaId { get; set; }
    public int? MvRecordId { get; set; }
    public string? TraImg { get; set; }

    public virtual Kartodromo Kartodromo { get; set; } = null!;
    public virtual Sentido? Sentido { get; set; }
    public virtual Clima? Clima { get; set; }
    public virtual MelhorVolta? MvEstreia { get; set; }
    public virtual MelhorVolta? MvRecord { get; set; }
}
