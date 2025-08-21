namespace MKnet.Landing.Strategy.Domain.Models
{
    public record ServiceDTO(string Title, string SubTitle, string Image, string Link, string Description);
    public record MemberDTO(string Name, string Position, string Image, string Description, string WhatsappUrl, string DiscordUrl);
    public record FaqDTO(string Question, string Answer, string Link);
    public record AboutDTO(string Title = "", string Image = "about.webp", string Description = "");
    public record HeroDTO(string Title= "", string Image = "hero.webp", string Description = "");
    public record FooterDTO(string Title = "", string Description = "");
    public record SectionDTO(string Title = "", string Link = "");
    public record MediaDTO(string Title = "", string Category = "", string Image = "media.png");
}
