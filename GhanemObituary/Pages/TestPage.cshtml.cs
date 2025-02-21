using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesSample.Pages;

public class TestPageModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public TestPageModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
