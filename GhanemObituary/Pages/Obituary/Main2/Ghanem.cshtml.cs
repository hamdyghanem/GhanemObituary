using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesSample.Pages;

public class GhanemModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public GhanemModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
