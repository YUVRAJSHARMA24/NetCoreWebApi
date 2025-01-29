using FootBallersApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FootBallersApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<FootballerModel> Footballers { get; set; }

    }
}
