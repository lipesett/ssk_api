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
    public int TraTracado { get; set; }
    public int TemTemporada { get; set; }
    public int PilPilotoVencedor { get; set; }

    public virtual Tracado Tracado { get; set; } = null!;
    public virtual Temporada Temporada { get; set; } = null!;
    public virtual PilotoModel PilotoVencedor { get; set; } = null!;
}