using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SweetSavory.Models;
using System.Linq;
using System.Dynamic;

namespace SweetSavory.Controllers
{
  public class HomeController : Controller
  {
    private readonly SweetSavoryContext _db;
    public HomeController(SweetSavoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Message = "Welcome to the sweet thang!";
      dynamic mymodel = new ExpandoObject();
      mymodel.Treats = _db.Treats.ToList();
      mymodel.Flavors = _db.Flavors.ToList();
      return View(mymodel);
    }
  }
}