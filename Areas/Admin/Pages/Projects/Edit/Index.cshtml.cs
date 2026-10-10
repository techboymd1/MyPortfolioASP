using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPortfolioASP.Models;
using MyPortfolioASP.Services;

namespace MyPortfolioASP.Areas.Admin.Pages.Projects.Edit;

public class IndexModel : PageModel
{
    private readonly ProjectService _projectService;

    public IndexModel(ProjectService projectService)
    {
        _projectService = projectService;
    }

    [BindProperty]
    public Project Project { get; set; } = new();

    public void OnGet(int id)
    {
        Project = _projectService.Projects.First(p => p.Id == id);
    }

    public IActionResult OnPost()
    {
        var existingProject = _projectService.Projects.First(p => p.Id == Project.Id);

        existingProject.Number = Project.Number;
        existingProject.Name = Project.Name;
        existingProject.Description = Project.Description;
        existingProject.Technologies = Project.Technologies;
        existingProject.Link = Project.Link;
        existingProject.Status = Project.Status;

        return RedirectToPage("/Projects/Index");
    }
}