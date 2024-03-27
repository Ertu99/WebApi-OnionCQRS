using WebApi_OnionCQRS.Domain.Common;

namespace WebApi_OnionCQRS.Domain.Entities;

public class Brand: EntityBase  
{
    public Brand()
    {}
    public Brand(string name)
    {
        Name = name;
    }
    public required string Name { get; set; }
}