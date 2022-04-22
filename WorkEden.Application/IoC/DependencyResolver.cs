using Autofac;
using AutoMapper;
using EdenWorks.Domain.Repositories;
using EdenWorks.Infrastructure.Repositories;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkEden.Application.AutoMapper;
using WorkEden.Application.Models.DTOs.CategoryDTO;
using WorkEden.Application.Services.CategoryService;
using WorkEden.Application.Validation.FluentValidation.CategoryValidator;

namespace WorkEden.Application.IoC
{
    public class DependencyResolver : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryRepo>().As<ICategoryRepo>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepo>().As<IProductRepo>().InstancePerLifetimeScope();
            builder.RegisterType<AppUserRepo>().As<IAppUserRepo>().InstancePerLifetimeScope();

            builder.RegisterType<CategoryService>().As<ICategoryService>().InstancePerLifetimeScope();
            
            #region AutoMapper
            //AutoMapper resolving
            builder.Register(context => new MapperConfiguration(cfg =>
            {
                //Register Mapper Profile
                cfg.AddProfile<Mapping>();
            }
              )).AsSelf().SingleInstance();

            builder.Register(c =>
            {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();

            #endregion
            
            #region Fluent Validation
            builder.RegisterType<CreateCategoryValidation>().As<IValidator<CreateCategoryDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<UpdateCategoryValidation>().As<IValidator<UpdateCategoryDTO>>().InstancePerLifetimeScope();
            #endregion

            base.Load(builder);
        }
    }
}
