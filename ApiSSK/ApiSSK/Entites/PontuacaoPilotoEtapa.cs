public partial class PontuacaoPilotoEtapa
{
    public int PpeId { get; set; }
    public int PilId { get; set; }
    public int CalId { get; set; }
    public int PonId { get; set; }
    public string? PpeTempoMelhorVolta { get; set; }
    public bool MelhorVolta { get; set; }

    public virtual Piloto Piloto { get; set; } = null!;
    public virtual Calendario Calendario { get; set; } = null!;
    public virtual Pontuacao Pontuacao { get; set; } = null!;
}