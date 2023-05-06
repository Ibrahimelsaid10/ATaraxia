namespace ATaraxia.Core.Models;

public class UserLike
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public Guid TemplateId { get; set; }
    public virtual Template? Template { get; set; }
}
