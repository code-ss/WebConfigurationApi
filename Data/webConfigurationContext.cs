using Microsoft.EntityFrameworkCore;
using WebConfigurationApi.Models.EntityModel;

namespace WebConfigurationApi.Data
{
    public class webConfigurationContext : DbContext
    {
        public webConfigurationContext(DbContextOptions<webConfigurationContext> options)
            : base(options)
        {
        }
        public DbSet<SvgLibraryModel> dbSvgLibrary { get; set; }//存节点的 
    }
}
