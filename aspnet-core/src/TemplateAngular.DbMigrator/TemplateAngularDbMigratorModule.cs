using TemplateAngular.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TemplateAngular.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TemplateAngularEntityFrameworkCoreModule),
    typeof(TemplateAngularApplicationContractsModule)
    )]
public class TemplateAngularDbMigratorModule : AbpModule
{
}
