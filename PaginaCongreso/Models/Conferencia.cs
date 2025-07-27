namespace PaginaCongreso.Models
{
    public class ConferenciaSistemas
    {
        public int codigo_Conferencia { get; set; }
        public string Conferencista { get; set; }
        public int codigo_Congreso { get; set; }
        public string nombre_Conferencia { get; set; }
        public DateTime fecha_Conferencia { get; set; }
        public string salon_Conferencia { get; set; }
        public bool estado_Conferencia { get; set; }
    }
    public class ConferenciaIndustrial
    {
        public int codigo_Conferencia { get; set; }
        public string Conferencista { get; set; }
        public int codigo_Congreso { get; set; }
        public string nombre_Conferencia { get; set; }
        public DateTime fecha_Conferencia { get; set; }
        public string salon_Conferencia { get; set; }
        public bool estado_Conferencia { get; set; }
    }
    public class ConferenciaEconomicas
    {
        public int codigo_Conferencia { get; set; }
        public string Conferencista { get; set; }
        public int codigo_Congreso { get; set; }
        public string nombre_Conferencia { get; set; }
        public DateTime fecha_Conferencia { get; set; }
        public string salon_Conferencia { get; set; }
        public bool estado_Conferencia { get; set; }
    }
}
