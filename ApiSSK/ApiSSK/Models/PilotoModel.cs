public partial class PilotoModel
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Sobrenome { get; set; }
    public int Podiuns { get; set; }
    public int CorridasOfc { get; set; }
    public int Campeao { get; set; }
    public int MelhorChegada { get; set; }
    public int UltimaTemp { get; set; }
    public int VoltasRapidas { get; set; }
    public int PolePosition { get; set; }
    public string? Peso { get; set; }
    public int MelhorQuali { get; set; }
    public string? LinksFotos { get; set; }
    public int? StatusId { get; set; }

    public virtual StatusModel? Status { get; set; }
}