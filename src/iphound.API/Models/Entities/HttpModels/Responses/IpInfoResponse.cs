namespace iphound.API.Models.Entities.HttpModels.Responses;

public class IpInfoResponse
{
    public string IP { get; set; }
    public string CountryName { get; set; }
    public string TwoLetterCode { get; set; }
    public string ThreeLetterCode { get; set; }
    public bool Success { get; set; }
}