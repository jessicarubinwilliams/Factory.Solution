using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {

    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<object> MachineList = _db.Machines.ToList();
      List<object> EngineerList = _db.Engineers.ToList();

      Dictionary<string, List<object>> modelList = new Dictionary<string, List<object>>() { {"Engineers", EngineerList} };
      
      return View(modelList);
    }
  }
}