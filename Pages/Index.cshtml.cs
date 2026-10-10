using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPortfolioASP.Models;
using MyPortfolioASP.Services;

namespace MyPortfolioASP.Pages;

public class IndexModel : PageModel
{
    private readonly ProjectService _projectService;

    public string Name = "";
    public string Role = "";
    public string Intro = "";

    public List<Project> Projects =>
     _projectService.Projects
         .Where(p => p.Status == "Published")
         .ToList();

    public IndexModel(ProjectService projectService)
    {
        _projectService = projectService;
    }

    public void OnGet()
    {
        Name = "Muhammad Ishaq";
        Role = "WEB DEVELOPER";
        Intro = "Building digital products that solve real problems.";
    }
}
