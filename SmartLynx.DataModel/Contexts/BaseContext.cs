using Microsoft.EntityFrameworkCore;
using SmartLynx.DataModel.FileModels;

namespace SmartLynx.DataModel.Contexts
{
    public abstract class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions options) : base(options)
        {

        }
    }
}