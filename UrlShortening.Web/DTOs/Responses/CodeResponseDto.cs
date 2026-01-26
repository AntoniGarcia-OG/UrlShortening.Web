namespace UrlShortening.Web.DTOs.Responses
{
    public class CodeResponseDto
    {
        public string OriginalUrl { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }
    }
}
