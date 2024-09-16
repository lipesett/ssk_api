public partial class PontuacaoPilotoEtapaModel
{
    public int PpeId { get; set; }
    public string? PpeTempoMelhorVolta { get; set; }
    public bool MelhorVolta { get; set; }
    public int PilotoId { get; set; }
    public int CalendarioId { get; set; }
    public int PontuacaoId { get; set; }

    public virtual PilotoModel Piloto { get; set; } = null!;
    public virtual CalendarioModel Calendario { get; set; } = null!;
    public virtual PontuacaoModel Pontuacao { get; set; } = null!;
}