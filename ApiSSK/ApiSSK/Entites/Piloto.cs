public partial class Piloto
{
    public int PilId { get; set; }
    public string PilNome { get; set; } = null!;
    public string PilSobrenome { get; set; } = null!;
    public int PilPodiums { get; set; }
    public int PilCorridasOfc { get; set; }
    public int PilCampeao { get; set; }
    public int PilMelhorChegada { get; set; }
    public int PilUltimaTemp { get; set; }
    public int PilVoltasRapidas { get; set; }
    public int PilPolePosition { get; set; }
    public string PilPeso { get; set; } = null!;
    public int PilMelhorQuali { get; set; }
    public string PilLinksFotos { get; set; } = null!;
    public int StaId { get; set; }

    public virtual Status Status { get; set; } = null!;
}