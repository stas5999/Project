using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.structure.Configuration
{
    public class OrderItemConfig : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> oi)
        {
            oi.HasKey(x => new { x.ItemId, x.OrderId });


            oi.HasOne(x => x.Order)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.ItemId);




            oi.HasOne(x => x.Item)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.OrderId);
        }
    }
}
