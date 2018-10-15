
namespace XamarinNative.BackEnd.Models
{
    using XamarinNative.Domain.Models;
    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<XamarinNative.Common.Models.Product> Products { get; set; }
    }
}