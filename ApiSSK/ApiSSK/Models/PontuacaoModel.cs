public partial class PontuacaoModel
{
    public int Id { get; set; }
    public int Posicao { get; set; }
    public int Pontos { get; set; }
    public int? TemporadaId { get; set; }

    public virtual TemporadaModel? Temporada { get; set; }
}