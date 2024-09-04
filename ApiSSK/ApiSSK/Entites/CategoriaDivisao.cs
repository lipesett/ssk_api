public partial class CategoriaDivisao
{
    public int CatId { get; set; }
    public int DivId { get; set; }

    public virtual Categoria Categoria { get; set; } = null!;
    public virtual Divisao Divisao { get; set; } = null!;
}