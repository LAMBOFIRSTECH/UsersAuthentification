using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using users.Models;
namespace users.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;
  

    public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }
     
    public string GetDbConnection()
    {
        var con = _configuration["ConnectionStrings:MvcUsersContext"];
        _logger.LogDebug("debut");
        _logger.LogDebug(con);
        _logger.LogDebug("fin");
        return con;
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
