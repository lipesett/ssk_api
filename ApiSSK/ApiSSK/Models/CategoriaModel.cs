public partial class CategoriaModel
{
    public int CatId { get; set; }
    public string CatNome { get; set; } = null!;
    public int StaId { get; set; }

    public virtual Status Status { get; set; } = null!;
}