using ApiSSK.Models.Enums;

public partial class CategoriaModel
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public EStatus Status { get; set; }
}