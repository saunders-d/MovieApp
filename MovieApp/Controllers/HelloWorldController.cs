using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers;

public class HelloWorldController : Controller
{
    // GET
    public string Index()
    {
        return "This is the default action";
    }
    
    public string Welcome(string name, int id)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");
    }
}