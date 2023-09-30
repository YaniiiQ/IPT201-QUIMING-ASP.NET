using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Jesse James", StudentId = "S001", StudentAge = "20" },
            new StudentInfoModel { Name = "Uri Evangelista", StudentId = "S002", StudentAge = "16" },
            new StudentInfoModel { Name = "Ian Quiming", StudentId = "S003", StudentAge = "19" }
        };

        return View(studentInfoArray);
    }
}
