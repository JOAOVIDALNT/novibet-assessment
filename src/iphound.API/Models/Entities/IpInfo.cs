using iphound.API.Models.Entities.Base;

namespace iphound.API.Models.Entities;

public class IpInfo : BaseEntity
{
    public string CountryName { get; set; }
    public string TwoLetterCode { get; set; }
    public string ThreeLetterCode { get; set; }
}