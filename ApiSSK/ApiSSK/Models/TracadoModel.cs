using ApiSSK.Models.Enums;

public partial class TracadoModel
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public DateTime DataEstreia { get; set; }
    public int KartodromoId { get; set; }
    public int? MvEstreiaId { get; set; }
    public int? MvRecordId { get; set; }
    public string? Img { get; set; }
    public ESentido Sentido { get; set; }
    public EClima Clima { get; set; }
    
    public virtual KartodromoModel? Kartodromo { get; set; }
    public virtual MelhorVoltaModel? MvEstreia { get; set; }
    public virtual MelhorVoltaModel? MvRecord { get; set; }
}