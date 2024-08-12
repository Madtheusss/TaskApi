using Microsoft.AspNetCore.Mvc;
using TaskApi.ModelViews;

namespace TaskApi.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public HomeView Index()
    {
        return new HomeView
        {
            Message = "Welcome to the Task API",
            Documentation = "/swagger"
        };
    }
}