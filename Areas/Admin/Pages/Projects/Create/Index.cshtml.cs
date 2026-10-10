using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPortfolioASP.Models;
using MyPortfolioASP.Services;

namespace MyPortfolioASP.Areas.Admin.Pages.Projects.Create;

public class IndexModel : PageModel
{
    private readonly ProjectService _projectService;

    public IndexModel(ProjectService projectService)
    {
        _projectService = projectService;
    }

    [BindProperty]
    public Project Project { get; set; } = new Project();

    public IActionResult OnPost()
    {
        Project.Id = _projectService.GetNextId();

        _projectService.Projects.Add(Project);

        return RedirectToPage("/Projects/Index");
    }
}