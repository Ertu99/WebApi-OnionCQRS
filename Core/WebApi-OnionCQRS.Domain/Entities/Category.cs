using WebApi_OnionCQRS.Domain.Common;

namespace WebApi_OnionCQRS.Domain.Entities;

public class Category : EntityBase,IEntityBase
{
    public Category()
    {
       
    }
    
    public Category(int parentId, string name, int priority)
    {
        ParentId = parentId;
        Name = name;
        Priority = priority;
       
    }

    public required int ParentId { get; set; }
    public required string Name { get; set; }
    public required int Priority { get; set; }
}
