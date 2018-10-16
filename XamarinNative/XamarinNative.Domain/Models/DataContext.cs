

namespace XamarinNative.Domain.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {

        public DataContext() : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<XamarinNative.Common.Models.Product> Products { get; set; }
    }
}

