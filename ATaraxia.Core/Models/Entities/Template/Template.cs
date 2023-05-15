namespace ATaraxia.Core.Models;

public class Template
{
    public Guid TemplateId { get; set; }
    public Type Type { get; set; } = Type.Stress;
    public string? Title { get; set; }
    public string? FileUrl { get; set; }
    public string? Picture { get; set; }
    public string? File { get; set; }
    public bool IsVideo { get; set; }
    public List<ApplicationUser>? UserLikes { get; set; }

    public void Compare()
    {

    bool x = Type.Equals(Type.Breathe);
    }

}


