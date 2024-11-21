public partial class InscricaoModel
{
    public int Id { get; set; }
    public DateTime DataInscricao { get; set; }
    public bool Pago { get; set; }
    public int? TemporadaId { get; set; }
    public int? PilotoId { get; set; }
    public int? CategoriaId { get; set; }
    public int? DivisaoId { get; set; }

    public virtual TemporadaModel? Temporada { get; set; }
    public virtual PilotoModel? Piloto { get; set; }
    public virtual CategoriaModel? Categoria { get; set; }
    public virtual DivisaoModel? Divisao { get; set; }
}
