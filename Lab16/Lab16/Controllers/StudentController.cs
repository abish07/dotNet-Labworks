using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;


public class StudentController : Controller
{
    private readonly IMemoryCache memoryCache;
    public StudentController(IMemoryCache memoryCache)
    {
        this.memoryCache = memoryCache;
    }
    public IActionResult Index()
    {
        DateTime currentTime;
        bool isExist = memoryCache.TryGetValue("CacheTime", out currentTime);
        if (!isExist)
        {
            currentTime = DateTime.Now;
            memoryCache.Set("CacheTime", currentTime, TimeSpan.FromSeconds(30));
        }
        return View("Index",currentTime);
    }
}