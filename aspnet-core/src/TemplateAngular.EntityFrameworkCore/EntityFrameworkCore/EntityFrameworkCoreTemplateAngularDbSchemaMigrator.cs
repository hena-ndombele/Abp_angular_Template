using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TemplateAngular.Data;
using Volo.Abp.DependencyInjection;

namespace TemplateAngular.EntityFrameworkCore;

public class EntityFrameworkCoreTemplateAngularDbSchemaMigrator
    : ITemplateAngularDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTemplateAngularDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the TemplateAngularDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TemplateAngularDbContext>()
            .Database
            .MigrateAsync();
    }
}
