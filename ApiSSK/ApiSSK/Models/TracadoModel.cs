﻿public partial class TracadoModel
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public DateTime DataEstreia { get; set; }
    public int KartodromoId { get; set; }
    public int? SentidoId { get; set; }
    public int? ClimaId { get; set; }
    public int? MvEstreiaId { get; set; }
    public int? MvRecordId { get; set; }
    public string? Img { get; set; }

    public virtual KartodromoModel? Kartodromo { get; set; }
    public virtual SentidoModel? Sentido { get; set; }
    public virtual ClimaModel? Clima { get; set; }
    public virtual MelhorVoltaModel? MvEstreia { get; set; }
    public virtual MelhorVoltaModel? MvRecord { get; set; }
}