using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers;

public class HelloWorldController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public string Welcome(string name, int id)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");
    }
}