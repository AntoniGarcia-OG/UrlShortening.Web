namespace UrlShortening.Web.Services
{
    public class CodeService
    {
        private readonly HttpClient _httpClient;

        public CodeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}
