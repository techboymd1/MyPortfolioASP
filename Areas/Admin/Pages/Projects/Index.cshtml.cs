using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPortfolioASP.Services;

namespace MyPortfolioASP.Areas.Admin.Pages.Projects;

public class IndexModel : PageModel
{
    private readonly ProjectService _projectService;

    public IndexModel(ProjectService projectService)
    {
        _projectService = projectService;
    }

    public List<Models.Project> Projects => _projectService.Projects;

    public void OnGet()
    {
    }

    public IActionResult OnPostDelete(int id)
    {
        var project = _projectService.Projects.FirstOrDefault(p => p.Id == id);

        if (project != null)
        {
            _projectService.Projects.Remove(project);
        }

        return RedirectToPage();
    }
}