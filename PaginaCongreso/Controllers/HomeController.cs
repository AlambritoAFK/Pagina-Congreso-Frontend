using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PaginaCongreso.Models;

namespace PaginaCongreso.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var conferencias = ObtenerConferencias().ToList();
        var conferenciasIndus = ObtenerConferenciaIndustrial().ToList();
        var conferenciasEcono = ObtenerConferenciaEconomicas().ToList();

        var modelo = new HomeIndexViewModel() 
        {
            ConferenciasSis = conferencias,
            ConferenciasIndus = conferenciasIndus,
            ConferenciasEcono = conferenciasEcono
        };
        return View(modelo);
    }

    private List<ConferenciaSistemas> ObtenerConferencias()
    {
        return new List<ConferenciaSistemas> {
            new ConferenciaSistemas
            {
                codigo_Conferencia = 1,
                Conferencista = "Dra. Marcela Ruiz",
                codigo_Congreso = 101,
                nombre_Conferencia = "Innovación Educativa en el Siglo XXI",
                fecha_Conferencia = new DateTime(2025, 8, 12, 10, 0, 0),
                salon_Conferencia = "Auditorio A",
                estado_Conferencia = true
            },
            new ConferenciaSistemas
            {
                codigo_Conferencia = 2,
                Conferencista = "Ing. Carlos Méndez",
                codigo_Congreso = 101,
                nombre_Conferencia = "Inteligencia Artificial y Ética",
                fecha_Conferencia = new DateTime(2025, 8, 12, 14, 0, 0),
                salon_Conferencia = "Salón 3",
                estado_Conferencia = true
            },
            new ConferenciaSistemas
            {
                codigo_Conferencia = 3,
                Conferencista = "Mtra. Ana Castillo",
                codigo_Congreso = 102,
                nombre_Conferencia = "Diseño UX: Más allá de la interfaz",
                fecha_Conferencia = new DateTime(2025, 9, 5, 9, 30, 0),
                salon_Conferencia = "Sala de Creatividad",
                estado_Conferencia = true
            },
            new ConferenciaSistemas
            {
                codigo_Conferencia = 4,
                Conferencista = "Dr. Ernesto Ramírez",
                codigo_Congreso = 102,
                nombre_Conferencia = "Ciberseguridad en Plataformas Web",
                fecha_Conferencia = new DateTime(2025, 9, 5, 13, 0, 0),
                salon_Conferencia = "Aula Magna",
                estado_Conferencia = true
            },
            new ConferenciaSistemas
            {
                codigo_Conferencia = 5,
                Conferencista = "Lic. Paula Ortega",
                codigo_Congreso = 103,
                nombre_Conferencia = "Narrativa Digital y Sociedad",
                fecha_Conferencia = new DateTime(2025, 10, 2, 15, 30, 0),
                salon_Conferencia = "Salón Multimedia",
                estado_Conferencia = false // Se canceló o se dará más adelante
            }
        };
    }
    private List<ConferenciaIndustrial> ObtenerConferenciaIndustrial()
    {
        return new List<ConferenciaIndustrial>{
            new ConferenciaIndustrial
            {
                codigo_Conferencia = 6,
                Conferencista = "Ing. Patricia Zamora",
                codigo_Congreso = 201,
                nombre_Conferencia = "Optimización de Procesos de Manufactura",
                fecha_Conferencia = new DateTime(2025, 8, 20, 10, 0, 0),
                salon_Conferencia = "Sala Técnica 1",
                estado_Conferencia = true
            },
            new ConferenciaIndustrial
            {
                codigo_Conferencia = 7,
                Conferencista = "Ing. Leonardo Jiménez",
                codigo_Congreso = 201,
                nombre_Conferencia = "Lean Manufacturing en América Latina",
                fecha_Conferencia = new DateTime(2025, 8, 20, 13, 30, 0),
                salon_Conferencia = "Sala Técnica 2",
                estado_Conferencia = true
            },
            new ConferenciaIndustrial
            {
                codigo_Conferencia = 8,
                Conferencista = "Mtra. Silvia Galindo",
                codigo_Congreso = 202,
                nombre_Conferencia = "Ingeniería de Calidad: Más allá del control",
                fecha_Conferencia = new DateTime(2025, 9, 3, 9, 0, 0),
                salon_Conferencia = "Auditorio B",
                estado_Conferencia = true
            },
            new ConferenciaIndustrial
            {
                codigo_Conferencia = 9,
                Conferencista = "Dr. Rafael Gutiérrez",
                codigo_Congreso = 202,
                nombre_Conferencia = "Robótica y Automatización en la Producción",
                fecha_Conferencia = new DateTime(2025, 9, 3, 14, 0, 0),
                salon_Conferencia = "Laboratorio Industrial",
                estado_Conferencia = false
            },
            new ConferenciaIndustrial
            {
                codigo_Conferencia = 10,
                Conferencista = "Lic. Gabriela Aguilar",
                codigo_Congreso = 203,
                nombre_Conferencia = "Gestión de Proyectos en Ingeniería Industrial",
                fecha_Conferencia = new DateTime(2025, 10, 1, 11, 30, 0),
                salon_Conferencia = "Salón 5",
                estado_Conferencia = true
            }
        };
    }
    private List<ConferenciaEconomicas> ObtenerConferenciaEconomicas()
    {
        return new List<ConferenciaEconomicas>
        {
    new ConferenciaEconomicas
    {
        codigo_Conferencia = 11,
        Conferencista = "Eco. Mariana Pérez",
        codigo_Congreso = 301,
        nombre_Conferencia = "Inflación y mercados emergentes",
        fecha_Conferencia = new DateTime(2025, 8, 18, 9, 30, 0),
        salon_Conferencia = "Sala de Economía",
        estado_Conferencia = true
    },
    new ConferenciaEconomicas
    {
        codigo_Conferencia = 12,
        Conferencista = "Eco. Fernando López",
        codigo_Congreso = 301,
        nombre_Conferencia = "Análisis de comportamiento financiero",
        fecha_Conferencia = new DateTime(2025, 8, 18, 12, 0, 0),
        salon_Conferencia = "Aula Magna",
        estado_Conferencia = true
    },
    new ConferenciaEconomicas
    {
        codigo_Conferencia = 13,
        Conferencista = "Eco. Esteban Sánchez",
        codigo_Congreso = 302,
        nombre_Conferencia = "Economía circular y sostenibilidad",
        fecha_Conferencia = new DateTime(2025, 9, 6, 15, 0, 0),
        salon_Conferencia = "Auditorio Verde",
        estado_Conferencia = true
    },
    new ConferenciaEconomicas
    {
        codigo_Conferencia = 14,
        Conferencista = "Mtra. Claudia León",
        codigo_Congreso = 302,
        nombre_Conferencia = "Macroeconomía crítica: paradigmas y debates",
        fecha_Conferencia = new DateTime(2025, 9, 6, 11, 0, 0),
        salon_Conferencia = "Salón Pensamiento Económico",
        estado_Conferencia = true
    },
    new ConferenciaEconomicas
    {
        codigo_Conferencia = 15,
        Conferencista = "Dr. Arturo Gómez",
        codigo_Congreso = 303,
        nombre_Conferencia = "Finanzas públicas en América Latina",
        fecha_Conferencia = new DateTime(2025, 10, 4, 16, 0, 0),
        salon_Conferencia = "Sala de Finanzas",
        estado_Conferencia = false
    }
};

    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
