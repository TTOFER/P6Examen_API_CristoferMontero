namespace P6Examen_API_CristoferMontero.ModelsDTOs
{
    public class ActivoDTO
    {
        public int IDActivo { get; set; }
        public string? NombreActivo { get; set; }
        public string? NumeroSerie { get; set; }
        public decimal CostoActivo { get; set; }
        public string? Descripcion { get; set; }
        public string? Ubicacion { get; set; }
        public string? Responsable { get; set; }
        public decimal PorcentajeDepreciacion { get; set; }
        public int VidaUtilAnnios { get; set; }
        public DateOnly FechaRegistro { get; set; }
        public int EstadoActivo { get; set; }
    }
}
