using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KeyForge.Pages;

public class IndexModel(ILogger<IndexModel> logger)
    : PageModel {
    /* Class to handle backing logic for the webpage.
     */

    private readonly ILogger<IndexModel> _logger = logger;

    // - Handlers

    public void OnGet() { }
}