using System.ComponentModel.Design.Serialization;
using System.ComponentModel.Design;
using System.Runtime.Serialization;
using System.IO.Compression;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_10_Series_Home.Models;

namespace TP_10_Series_Home.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Series = BD.ObtenerSeries();
        return View();
    }

    public List<Temporada> ObtenerTemporadasAjax(int idSerie){
        ViewBag.Temporadas = BD.ObtenerTemporadas(idSerie);
        return ViewBag.Temporadas;
    }

    public List<Actor> ObtenerActoresAjax(int idSerie){
        ViewBag.Actores = BD.ObtenerActores(idSerie);
        return ViewBag.Actores;
    }

    public Serie ObtenerInfoAjax(int idSerie){
        ViewBag.Serie = BD.ObtenerSerie(idSerie);
        return ViewBag.Serie;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
