using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesSample.Pages.Obituary.Main2;

public class MostafaModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public MostafaModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
