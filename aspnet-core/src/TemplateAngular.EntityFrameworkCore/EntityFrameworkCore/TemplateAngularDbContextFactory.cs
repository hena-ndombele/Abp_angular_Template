using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TemplateAngular.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class TemplateAngularDbContextFactory : IDesignTimeDbContextFactory<TemplateAngularDbContext>
{
    public TemplateAngularDbContext CreateDbContext(string[] args)
    {
        TemplateAngularEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<TemplateAngularDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new TemplateAngularDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../TemplateAngular.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
