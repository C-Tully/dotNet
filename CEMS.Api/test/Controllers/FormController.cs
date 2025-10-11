namespace CEMSForms.Controller
{

  public class HomeController : Controller
  {

    [HttpGet]
    public IActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Index(string userInput)
    {
      switch (userInput)
      {
        case
      }
    }

    
    
  }  


}