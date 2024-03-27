using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi_OnionCQRS.Domain.Entities;

namespace WebApi_OnionCQRS.Persistence.Configurations;

public class CategoryConfiguration: IEntityTypeConfiguration<Category>
{
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                Id = 1,
                ParentId = 0,
                Name = "Elektrik",
                Priority = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };

            Category category2 = new()
            {
                Id = 2,
                ParentId = 0,
                Name = "Moda",
                Priority = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false 
            };
            Category parent1 = new()
            {
                Id = 3,
                ParentId = 1,
                Name = "Bilgisayar",
                Priority = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
            Category parent2 = new()
            {
                Id = 4,
                ParentId = 2,
                Name = "Kadin",
                Priority = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
            builder.HasData(category1, category2, parent1, parent2);
        }
    }

