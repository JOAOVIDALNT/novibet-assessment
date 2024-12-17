using iphound.API.Models.Entities.HttpModels.Responses;

namespace iphound.API.Providers.Service.IpService;

public interface IIpService
{
    Task<IpInfoResponse> RequestIp(string ip);
}