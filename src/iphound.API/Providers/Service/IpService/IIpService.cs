namespace iphound.API.Providers.Service.IpService;

public interface IIpService
{
    Task<bool> Test(string ip);
}