using iphound.API.Models.Entities.HttpModels.Responses;
using iphound.API.Utils;

namespace iphound.API.Providers.Service.IpService;

public class IpService : IIpService
{
    private readonly HttpClient _httpClient;
    
    public IpService(HttpClient httpClient)
    {
        _httpClient = httpClient; 
    }

    public async Task<IpInfoResponse> RequestIp(string ip)
    {
        var request = await _httpClient.GetAsync(ip);

        if (request.IsSuccessStatusCode)
        {
            var result = request.Content.ReadAsStringAsync().Result;
            return result.MapIpInfoResponse();
        }
        
        return new IpInfoResponse() { Success = false };    
    }
}