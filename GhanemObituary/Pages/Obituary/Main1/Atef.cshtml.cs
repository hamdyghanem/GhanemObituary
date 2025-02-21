using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesSample.Pages;

public class AtefModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public AtefModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
