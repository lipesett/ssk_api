public partial class PilotoModel
{
    public int PilId { get; set; }
    public string PilNome { get; set; }
    public string PilSobrenome { get; set; }
    public int PilPodiums { get; set; }
    public int PilCorridasOfc { get; set; }
    public int PilCampeao { get; set; }
    public int PilMelhorChegada { get; set; }
    public int PilUltimaTemp { get; set; }
    public int PilVoltasRapidas { get; set; }
    public int PilPolePosition { get; set; }
    public string PilPeso { get; set; }
    public int PilMelhorQuali { get; set; }
    public string PilLinksFotos { get; set; }
    public int StatusId { get; set; }

    public virtual StatusModel Status { get; set; }
}