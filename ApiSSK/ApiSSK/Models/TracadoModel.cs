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

    public virtual KartodromoModel Kartodromo { get; set; } = null!;
    public virtual Sentido? Sentido { get; set; }
    public virtual ClimaModel? Clima { get; set; }
    public virtual MelhorVoltaModel? MvEstreia { get; set; }
    public virtual MelhorVoltaModel? MvRecord { get; set; }
}
