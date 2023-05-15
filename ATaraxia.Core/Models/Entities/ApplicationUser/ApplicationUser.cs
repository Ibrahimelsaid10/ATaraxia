namespace ATaraxia.Core.Models;

public class ApplicationUser
{
    public Guid UserId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? NickName { get; set; }
    public string? loginStatus { get; set; }
    public bool gender { get; set; }

    public Guid TemplateId { get; set; }
    public Template? Template { get; set; }

    public List<Device>? DeviceIdList { get; set; }

    public List<Question>? Recomendation { get; set; }

    public List<RefreshToken>? RefreshTokens { get; set; }

}
