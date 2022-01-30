using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Clase7v2.EntityFrameworkCore
{
    public static class Clase7v2DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Clase7v2DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Clase7v2DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
