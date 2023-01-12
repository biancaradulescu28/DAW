
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public class ProiectContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<TicketDiscount> TicketDiscounts { get; set; }

        public ProiectContext(DbContextOptions<ProiectContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasMany(a => a.Events)
                .WithOne(e => e.Address);


            modelBuilder.Entity<TicketDiscount>()
                 .HasKey(td => new { td.TicketId, td.DiscountId });

            modelBuilder.Entity<Ticket>()
                .HasMany(t => t.TicketDiscounts)
                .WithOne(td => td.Ticket)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TicketDiscount>()
                        .HasOne(td => td.Ticket)
                        .WithMany(t => t.TicketDiscounts)
                        .HasForeignKey(td => td.TicketId);

            modelBuilder.Entity<TicketDiscount>()
                        .HasOne(td => td.Discount)
                        .WithMany(d => d.TicketDiscounts)
                        .HasForeignKey(td => td.DiscountId);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.Tickets)
                .WithOne(t => t.Order);

            modelBuilder.Entity<Event>()
                .HasMany(o => o.Tickets)
                .WithOne(e => e.Event);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.User);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Cart)
                .WithOne(c => c.User)
                .HasForeignKey<Cart>(c => c.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
