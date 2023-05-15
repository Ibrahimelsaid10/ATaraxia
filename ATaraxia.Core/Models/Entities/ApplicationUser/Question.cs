namespace ATaraxia.Core.Models;

public class Question
{
    public Guid Id { get; set; }

    public string? Ask { get; set; }
    public string? Answer { get; set; }

    public Guid ApplicationUserId { get; set; }
    public ApplicationUser? ApplicationUser { get; set; }

}
