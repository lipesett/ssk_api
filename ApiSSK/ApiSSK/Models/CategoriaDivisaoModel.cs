public partial class CategoriaDivisaoModel
{
    public int CatId { get; set; }
    public int DivId { get; set; }

    public virtual CategoriaModel Categoria { get; set; } = null!;
    public virtual DivisaoModel Divisao { get; set; } = null!;
}