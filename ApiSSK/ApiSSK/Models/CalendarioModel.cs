public partial class CalendarioModel
{
    public int CalId { get; set; }
    public string CalNomeEtapa { get; set; } = null!;
    public int CalNumEtapa { get; set; }
    public int CalDia { get; set; }
    public int CalMes { get; set; }
    public int CalAno { get; set; }
    public DateTime CalDataCompleta { get; set; }
    public TimeSpan CalHorario { get; set; }
    public int CalPtsDisputados { get; set; }
    public bool CalEtapaRealizada { get; set; }
    public int? TracadoId { get; set; }
    public int? TemporadaId { get; set; }
    public int? PilotoId { get; set; }

    public virtual TracadoModel? Tracado { get; set; }
    public virtual TemporadaModel? Temporada { get; set; } = null!;
    public virtual PilotoModel? Piloto { get; set; }
}