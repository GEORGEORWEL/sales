


namespace sales.domain.models
{
using System.Data.Entity;


    public class dataContext : DbContext
    {
        public dataContext() : base("DefaultConnection") //string de conection
        {

        }
    }
}
