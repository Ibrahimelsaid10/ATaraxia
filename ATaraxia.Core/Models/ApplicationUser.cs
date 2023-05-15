using Microsoft.AspNetCore.Identity;

namespace ATaraxia.Core.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Guid UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NickName { get; set; }
        public string? loginStatus { get; set; }
        public string? DeviceIdList { get; set; }
        public bool gender { get; set; }
        public string? recomendation { get; set; }
        public Guid TemplateId { get; set; }
        public List<RefreshToken>? RefreshTokens { get; set; }

    }
}
