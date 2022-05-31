using Autofac;
using AutoMapper;
using EdenWorks.Application.AutoMapper;
using EdenWorks.Application.Models.DTOs.CategoryDTO;
using EdenWorks.Application.Models.DTOs.EntryDTO;
using EdenWorks.Application.Models.DTOs.ProductDTO;
using EdenWorks.Application.Services.AppUserService;
using EdenWorks.Application.Services.CategoryService;
using EdenWorks.Application.Services.ProductService;
using EdenWorks.Application.Validation.FluentValidation.AppUserValidator;
using EdenWorks.Application.Validation.FluentValidation.CategoryValidator;
using EdenWorks.Application.Validation.FluentValidation.ProductValidator;
using EdenWorks.Domain.Repositories;
using EdenWorks.Infrastructure.Repositories;
using FluentValidation;


namespace EdenWorks.Application.IoC
{
    public class DependencyResolver : Module
    {
        // Resolving dependencies with Autofac Inversion of Control container.
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryRepo>().As<ICategoryRepo>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepo>().As<IProductRepo>().InstancePerLifetimeScope();
            builder.RegisterType<AppUserRepo>().As<IAppUserRepo>().InstancePerLifetimeScope();

            builder.RegisterType<CategoryService>().As<ICategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<AppUserService>().As<IAppUserService>().InstancePerLifetimeScope();

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
            builder.RegisterType<CreateProductValidation>().As<IValidator<CreateProductDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<UpdateProductValidation>().As<IValidator<UpdateProductDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<RegisterAppUserValidation>().As<IValidator<RegisterDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<LoginAppUserValidation>().As<IValidator<LoginDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<EditAppUserValidation>().As<IValidator<UpdateProfileDTO>>().InstancePerLifetimeScope();
            #endregion

            base.Load(builder);
        }
    }
}
