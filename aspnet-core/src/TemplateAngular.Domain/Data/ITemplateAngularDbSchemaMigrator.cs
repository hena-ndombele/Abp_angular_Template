using System.Threading.Tasks;

namespace TemplateAngular.Data;

public interface ITemplateAngularDbSchemaMigrator
{
    Task MigrateAsync();
}
