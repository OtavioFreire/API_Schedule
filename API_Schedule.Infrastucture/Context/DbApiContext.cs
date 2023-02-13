using API_Schedule.Infrastucture.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_Schedule.Infrastucture.Context
{
    public class DbApiContext : DbContext
    {
        public DbSet<ClassMeta> DBMeta { get; set; }
        public DbSet<ClassEvento> DBEvento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Password=7ifxvc39sp;Persist Security Info=True;User ID=OtavioPfreire_SQLLogin_2;Initial Catalog=ApiSchedule;Data Source=apischedule.mssql.somee.com");

            //Provider=SQLOLEDB.1;Password=7ifxvc39sp;Persist Security Info=True;User ID=OtavioPfreire_SQLLogin_2;Initial Catalog=ApiSchedule;Data Source=apischedule.mssql.somee.com
        }
    }
}
