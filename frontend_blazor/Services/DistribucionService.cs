using System.Text;
using System.Text.Json;
using BoleteriaOnline.Core.Data.Enums;
using BoleteriaOnline.Core.Services;
using BoleteriaOnline.Web.Utils;
using BoleteriaOnline.Web.ViewModels.Requests;
using BoleteriaOnline.Web.ViewModels.Responses;

namespace frontend_blazor.Services;
public class DistribucionService : IDistribucionService
{
    private readonly HttpClient _client;
    private readonly JsonSerializerOptions _options;

    public DistribucionService(HttpClient client)
    {
        this._client = client;
        _options = new JsonSerializerOptions { PropertyNamingPolicy = new SnakeCaseNamingPolicy() };
    }

    public async Task<WebResult<DistribucionResponse>> AppendFilasAsync(long id, Planta planta)
    {
        var response = await _client.PostAsJsonAsync($"/api/distribuciones/{id}/filas/{(int)planta}", planta);
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }
        return JsonSerializer.Deserialize<WebResult<DistribucionResponse>>(content, _options);
    }

    public Task<WebResult<DistribucionResponse>> CreateDistribucionAsync(DistribucionRequest DistribucionDto)
    {
        throw new NotImplementedException();
    }

    public Task<WebResult<DistribucionResponse>> DeleteDistribucionAsync(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<WebResult<DistribucionResponse>> GetDistribucionAsync(long id)
    {
        var response = await _client.GetAsync($"/api/distribuciones/{id}");
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }
        return JsonSerializer.Deserialize<WebResult<DistribucionResponse>>(content, _options);
    }

    public async Task<WebResult<ICollection<DistribucionResponse>>> GetDistribucionesAsync()
    {
        try
        {
            var response = await _client.GetAsync("/api/distribuciones");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            return JsonSerializer.Deserialize<WebResult<ICollection<DistribucionResponse>>>(content, _options);
        }
        catch (Exception ex)
        {
            return WebResponse.Error<ICollection<DistribucionResponse>>(ex.Message);
        }
    }

    public async Task<WebResult<DistribucionResponse>> UpdateDistribucionAsync(DistribucionUpdateRequest DistribucionDto, long id)
    {
        try
        {
            HttpContent httpContent = new StringContent(JsonSerializer.Serialize(DistribucionDto, _options), Encoding.UTF8, "application/json-patch+json");
            var response = await _client.PatchAsync($"/api/distribuciones/{id}", httpContent);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            return JsonSerializer.Deserialize<WebResult<DistribucionResponse>>(content, _options);
        }
        catch (Exception ex)
        {
            return WebResponse.Error<DistribucionResponse>(ex.Message);
        }
    }
}
