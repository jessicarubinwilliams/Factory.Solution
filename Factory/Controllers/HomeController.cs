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
      List<Machine> MachineList = _db.Machines.ToList();
      List<Engineer> EngineerList = _db.Engineers.ToList();

      Dictionary<List<Machine>, List<Engineer>> modelList = new Dictionary<List<Machine>, List<Engineer>>() { {MachineList, EngineerList} };
      
      return View(modelList);
    }
  }
}