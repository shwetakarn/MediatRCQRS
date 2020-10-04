using AspNetCoreMediatRSample.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMediatRSample.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt)
        {

        }

        public DbSet<Person> Persons {get; set;}
    }
}