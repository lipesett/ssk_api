public partial class PontuacaoModel
{
    public int PonId { get; set; }
    public int PonPosicao { get; set; }
    public int PonPontos { get; set; }
    public int TemporadaId { get; set; }

    public virtual TemporadaModel Temporada { get; set; } = null!;
}