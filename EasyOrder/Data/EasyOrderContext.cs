using Microsoft.EntityFrameworkCore;

namespace EasyOrder.Data
{
    class EasyOrderContext : DbContext
    {
        private readonly string _dbContext = @"Data Source=DESKTOP-AF6EDUF\SQLEXPRESSS;Initial Catalog=EasyOrderDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbContext);
        }
    }
}
