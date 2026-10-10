namespace MyPortfolioASP.Models;


public class Project
{
    public int Id { get; set; }
    
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string Technologies { get; set; } = "";
    public string Number { get; set; } = "";
    public string Link { get; set; } = "";
    public string Status { get; set; } = "";
}