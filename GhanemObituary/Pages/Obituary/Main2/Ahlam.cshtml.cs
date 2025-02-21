using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesSample.Pages;

public class AhlamModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public AhlamModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
