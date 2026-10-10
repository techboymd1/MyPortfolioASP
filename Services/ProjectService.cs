using MyPortfolioASP.Models;

namespace MyPortfolioASP.Services;

public class ProjectService
{
    public List<Project> Projects { get; } = new()
    {
        new Project
        {
            Id = 1,
            Number = "01",
            Name = "Student Study Planner",
            Description = "A productivity web application designed to help students organize and track their study tasks.",
            Technologies = "HTML • CSS • JavaScript",
            Link = "/StudentStudyPlanner",
           Status = "Published"
        },

        new Project
        {
            Id = 2,
            Number = "02",
            Name = "Cosmetics E-commerce Website",
            Description = "A business-focused e-commerce project designed to help customers discover and purchase products online.",
            Technologies = "HTML • CSS • JavaScript",
            Link = "",
           Status = "Published"
        }
    };

    public int GetNextId()
    {
        if (Projects.Count == 0)
        {
            return 1;
        }

        return Projects.Max(p => p.Id) + 1;
    }
}