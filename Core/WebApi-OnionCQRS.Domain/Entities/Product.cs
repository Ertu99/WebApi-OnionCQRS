using System.Diagnostics.Contracts;
using WebApi_OnionCQRS.Domain.Common;

namespace WebApi_OnionCQRS.Domain.Entities;

public class Product : EntityBase
{
     public string Name { get; set; }
     public string Title { get; set; }
     public required string Description { get; set; }
     public required int BrandId { get; set; }
     public required decimal Price { get; set; }
     public required decimal Discount { get; set; }
     public Brand Brand { get; set; }
     public ICollection<Category> Categories { get; set; }
    
}