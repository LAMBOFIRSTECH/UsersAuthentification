using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using users.Models;
namespace users.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Enrollment()
    {
        Utilisateur utilisateur = new Utilisateur();
        List<Utilisateur> utilisateurs= new List<Utilisateur>();
        utilisateurs.Add(utilisateur);
        return View(utilisateurs);
    }
    public IActionResult Connexion()
    {

        return View();
    }


   
}
