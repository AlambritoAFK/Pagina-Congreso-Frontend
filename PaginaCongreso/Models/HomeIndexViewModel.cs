namespace PaginaCongreso.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<ConferenciaSistemas> ConferenciasSis { get;set; }
        public IEnumerable<ConferenciaIndustrial> ConferenciasIndus { get; set; }
        public IEnumerable<ConferenciaEconomicas> ConferenciasEcono { get; set; }
    }
}
