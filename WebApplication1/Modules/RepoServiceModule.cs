
using Autofac;
using System.Reflection;
using week4_huseyingulerman.Core.Repositories;
using week4_huseyingulerman.Core.Services;
using week4_huseyingulerman.Core.UnitOfWork;
using week4_huseyingulerman.Repository.Repositories;
using week4_huseyingulerman.Repository.UnitOfWork;
using week4_huseyingulerman.Repository;
using week4_huseyingulerman.Service.Mapping;
using week4_huseyingulerman.Service.Services;

namespace week4_huseyingulerman.Api.Modules
{
    public class RepoServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {



            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<,,>)).As(typeof(IService<,,>)).InstancePerLifetimeScope();


            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
        }
    }
}
