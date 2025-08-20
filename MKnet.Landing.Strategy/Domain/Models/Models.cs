namespace MKnet.Landing.Strategy.Domain.Models
{
    public record ServiceDTO(string Title, string SubTitle, string Image, string Description);

    public record MemberDTO(string Name, string SubTitle, string Phone, string Image, string Description, string DiscordUrl);
}
