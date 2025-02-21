using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesSample.Pages.Obituary.Main1;

public class SikinaModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public SikinaModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
