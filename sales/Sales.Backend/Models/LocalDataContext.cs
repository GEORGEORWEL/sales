


namespace Sales.Backend.Models
{
    using sales.domain.models;
    public class LocalDataContext : dataContext
    {
        public System.Data.Entity.DbSet<sales.common.models.Product> Products { get; set; }
        // la idea de esta clase heredada es que las modificaciones de la bd se hagan en un dataset local heredado de la base de datos
    }
}