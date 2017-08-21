﻿using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities.Mappings
{
    internal class ProductAttributeMapping : EntityTypeConfiguration<ProductAttribute>
    {
        public ProductAttributeMapping()
        {
            this.HasRequired(x => x.Attribute)
                .WithMany()
                .HasForeignKey(x => x.AttributeId);
        }
    }
}
