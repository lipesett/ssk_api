public partial class DivisaoModel
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public int? StatusId { get; set; }

    public virtual StatusModel? Status { get; set; }
}