public partial class DivisaoModel
{
    public int DivId { get; set; }
    public string DivNome { get; set; }
    public int StatusId { get; set; }

    public virtual StatusModel Status { get; set; }
}