public partial class CategoriaModel
{
    public int CatId { get; set; }
    public string CatNome { get; set; }
    public int StatusId { get; set; }

    public virtual Status Status { get; set; }
}