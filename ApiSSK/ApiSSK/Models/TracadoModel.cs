public partial class TracadoModel
{
    public int TraId { get; set; }
    public string TraNome { get; set; } = null!;
    public DateTime TraDataEstreia { get; set; }
    public int KartodromoId { get; set; }
    public int? SentidoId { get; set; }
    public int? ClimaId { get; set; }
    public int? MvEstreiaId { get; set; }
    public int? MvRecordId { get; set; }
    public string? TraImg { get; set; }

    public virtual KartodromoModel Kartodromo { get; set; } = null!;
    public virtual SentidoModel? Sentido { get; set; }
    public virtual ClimaModel? Clima { get; set; }
    public virtual MelhorVoltaModel? MvEstreia { get; set; }
    public virtual MelhorVoltaModel? MvRecord { get; set; }
}
