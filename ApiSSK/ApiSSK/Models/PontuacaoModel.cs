public partial class Pontuacao
{
    public int PonId { get; set; }
    public int PonPosicao { get; set; }
    public int PonPontos { get; set; }
    public int TemTemporada { get; set; }

    public virtual Temporada Temporada { get; set; } = null!;
}