using iphound.API.Models.Entities.HttpModels.Responses;

namespace iphound.API.Utils;

public static class ResponseMapping
{
    public static IpInfoResponse MapIpInfoResponse(this string content)
    {
        var parts = content.Split(';');
        
        var response = new IpInfoResponse
        {
            TwoLetterCode = parts[1],
            ThreeLetterCode = parts[2],
            CountryName = parts[3],
            Success = true
        };
        return response;
    }
}