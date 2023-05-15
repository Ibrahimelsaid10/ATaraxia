namespace ATaraxia.Core.Models;

public class Template
{
    public Guid TemplateId { get; set; }
    public string? Title { get; set; }
    public string? FileUrl { get; set; }
    public string? Picture { get; set; }
    public string? File { get; set; }
    public bool IsVideo { get; set; }
    public string? UserLikes { get; set; }
   
}


