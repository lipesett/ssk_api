public partial class Inscricao
{
    public int InsId { get; set; }
    public int PilId { get; set; }
    public int CatId { get; set; }
    public int DivId { get; set; }
    public DateTime InsDataInscricao { get; set; }
    public int? InsPago { get; set; }
    public int TemId { get; set; }

    public virtual Piloto Piloto { get; set; } = null!;
    public virtual Categoria Categoria { get; set; } = null!;
    public virtual Divisao Divisao { get; set; } = null!;
    public virtual Temporada Temporada { get; set; } = null!;
}
