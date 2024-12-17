namespace iphound.API.Providers.Service.IpService;

public class IpService : IIpService
{
    private readonly HttpClient _httpClient;
    
    public IpService(HttpClient httpClient)
    {
        _httpClient = httpClient; 
    }

    public async Task<bool> Test(string ip)
    {
        var request = await _httpClient.GetAsync(ip);

        var result = request.Content.ReadAsStringAsync().Result;
        
        return true;
    }
}