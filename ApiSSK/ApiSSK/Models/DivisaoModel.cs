public partial class DivisaoModel
{
    public int DivId { get; set; }
    public string DivNome { get; set; } = null!;
    public int StaId { get; set; }

    public virtual Status Status { get; set; } = null!;
}