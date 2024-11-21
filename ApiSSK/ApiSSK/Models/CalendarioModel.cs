public partial class CalendarioModel
{
    public int Id { get; set; }
    public string? NomeEtapa { get; set; }
    public int NumEtapa { get; set; }
    public int Dia { get; set; }
    public int Mes { get; set; }
    public int Ano { get; set; }
    public DateTime DataCompleta { get; set; }
    public TimeSpan Horario { get; set; }
    public int PtsDisputados { get; set; }
    public bool EtapaRealizada { get; set; }
    public int? TracadoId { get; set; }
    public int? TemporadaId { get; set; }
    public int? PilotoId { get; set; }

    public virtual TracadoModel? Tracado { get; set; }
    public virtual TemporadaModel? Temporada { get; set; }
    public virtual PilotoModel? Piloto { get; set; }
}