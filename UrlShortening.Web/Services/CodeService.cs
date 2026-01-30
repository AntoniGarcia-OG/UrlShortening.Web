using System.Net.Http.Json;
using UrlShortening.Web.DTOs.Requests;
using UrlShortening.Web.DTOs.Responses;

namespace UrlShortening.Web.Services
{
    public class CodeService
    {
        private readonly HttpClient _httpClient;

        public CodeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CodeResponseDto?> CreateAsync(string originalUrl)
        {
            CreateCodeDto dto = new()
            {
                OriginalUrl = originalUrl
            };

            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("/api/UrlMapping", dto);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            return await response.Content.ReadFromJsonAsync<CodeResponseDto>();
        }
    }
}
