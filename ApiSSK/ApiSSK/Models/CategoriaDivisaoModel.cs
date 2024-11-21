public partial class CategoriaDivisaoModel
{
    public int? CategoriaId { get; set; }
    public int? DivisaoId { get; set; }

    public virtual CategoriaModel? Categoria { get; set; }
    public virtual DivisaoModel? Divisao { get; set; }
}