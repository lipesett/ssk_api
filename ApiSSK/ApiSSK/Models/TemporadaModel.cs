public partial class TemporadaModel
{
    public int TemId { get; set; }
    public int TemNumTem { get; set; }
    public string TemNome { get; set; } = null!;
    public int TemEtapas { get; set; }
    public DateTime TemInicio { get; set; }
    public DateTime TemFinal { get; set; }
    public int TemAno { get; set; }
    public int StatusId { get; set; }

    public virtual StatusModel Status { get; set; } = null!;
}