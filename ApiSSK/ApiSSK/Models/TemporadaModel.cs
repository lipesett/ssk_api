public partial class Temporada
{
    public int TemId { get; set; }
    public int TemNumTem { get; set; }
    public string TemNome { get; set; } = null!;
    public int TemEtapas { get; set; }
    public DateTime TemInicio { get; set; }
    public DateTime TemFinal { get; set; }
    public int TemAno { get; set; }
    public int StaId { get; set; }

    public virtual Status Status { get; set; } = null!;
}