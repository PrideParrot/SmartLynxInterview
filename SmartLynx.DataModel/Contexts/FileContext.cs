using Microsoft.EntityFrameworkCore;
using SmartLynx.DataModel.FileModels;

namespace SmartLynx.DataModel.Contexts
{
    public class FileContext : BaseContext
    {
        public FileContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FileModel> Files { get; set; }
    }
}