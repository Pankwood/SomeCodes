using Company.DomainModels;
using System.Data.Entity;

namespace Company.DataAcess
{
    public partial class Context : DbContext
    {
        public DbSet<Value> Value { get; set; }

    }
}
