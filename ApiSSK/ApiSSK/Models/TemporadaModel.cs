using ApiSSK.Models.Enums;

public partial class TemporadaModel
{
    public int Id { get; set; }
    public int NumTem { get; set; }
    public string? Nome { get; set; }
    public int Etapas { get; set; }
    public DateTime Inicio { get; set; }
    public DateTime Final { get; set; }
    public int Ano { get; set; }
    public EStatus Status { get; set; }
}