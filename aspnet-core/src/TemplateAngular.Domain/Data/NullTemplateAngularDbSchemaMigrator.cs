using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TemplateAngular.Data;

/* This is used if database provider does't define
 * ITemplateAngularDbSchemaMigrator implementation.
 */
public class NullTemplateAngularDbSchemaMigrator : ITemplateAngularDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
