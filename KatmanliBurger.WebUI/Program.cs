using FluentValidation.AspNetCore;
using KatmanliBurger.Dal.Abstracts;
using KatmanliBurger.Dal.Concretes.EntityFramework;
using KatmanliBurger.Dal.Contexts;
using KatmanliBurger.Data.Concretes;
using KatmanliBurger.Service.Services.BasketServices;
using KatmanliBurger.Service.Services.BurgerGarnitureMappingServices;
using KatmanliBurger.Service.Services.BurgerMenuMappingServices;
using KatmanliBurger.Service.Services.BurgerOrderMappingServices;
using KatmanliBurger.Service.Services.BurgerServices;
using KatmanliBurger.Service.Services.ByProductServices;
using KatmanliBurger.Service.Services.CategoryServices;
using KatmanliBurger.Service.Services.CustomerMessageServices;
using KatmanliBurger.Service.Services.GarnitureServices;
using KatmanliBurger.Service.Services.MenuByProductMappingServices;
using KatmanliBurger.Service.Services.MenuOrderMappingServices;
using KatmanliBurger.Service.Services.MenuServices;
using KatmanliBurger.Service.Services.OrderByProductMappingServices;
using KatmanliBurger.Service.Services.OrderServices;
using KatmanliBurger.Service.Services.ParameterServices;
using KatmanliBurger.WebUI.Helpers;
using KatmanliBurger.Dal.Abstracts;
using KatmanliBurger.Dal.Concretes.EntityFramework;
using KatmanliBurger.Dal.Contexts;
using KatmanliBurger.Data.Concretes;
using KatmanliBurger.Service.Services.BasketServices;
using KatmanliBurger.Service.Services.BurgerGarnitureMappingServices;
using KatmanliBurger.Service.Services.BurgerMenuMappingServices;
using KatmanliBurger.Service.Services.BurgerOrderMappingServices;
using KatmanliBurger.Service.Services.BurgerServices;
using KatmanliBurger.Service.Services.ByProductServices;
using KatmanliBurger.Service.Services.CategoryServices;
using KatmanliBurger.Service.Services.CustomerMessageServices;
using KatmanliBurger.Service.Services.GarnitureServices;
using KatmanliBurger.Service.Services.MenuByProductMappingServices;
using KatmanliBurger.Service.Services.MenuOrderMappingServices;
using KatmanliBurger.Service.Services.MenuServices;
using KatmanliBurger.Service.Services.OrderByProductMappingServices;
using KatmanliBurger.Service.Services.OrderServices;
using KatmanliBurger.Service.Services.ParameterServices;
using KatmanliBurger.WebUI.Helpers;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using System.Reflection;

namespace KatmanliBurger.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddIdentity<AppUser, AppRole>(
     option =>
     {
         option.Password.RequiredLength = 8;
         option.Password.RequireUppercase = true;
         option.Password.RequireLowercase = true;
         option.Password.RequireNonAlphanumeric = true;
         option.User.RequireUniqueEmail = true;
     }).AddEntityFrameworkStores<BurgerDbContext>().AddRoleManager<RoleManager<AppRole>>();

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddFluentValidation(option => option.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly())).ConfigureApiBehaviorOptions(opt => opt.SuppressModelStateInvalidFilter = true);
            //builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());




            builder.Services.AddDbContext<BurgerDbContext>();

            builder.Services.AddScoped<IBurgerDal, EfBurgerDal>();
            builder.Services.AddScoped<IBurgerService, BurgerManager>();


            builder.Services.AddScoped<IMenuService, MenuManager>();
            builder.Services.AddScoped<IMenuDal, EfMenuDal>();

            builder.Services.AddScoped<IByProductDal, EfByProductDal>();
            builder.Services.AddScoped<IByProductService, ByProductManager>();

            builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
            builder.Services.AddScoped<ICategoryService, CategoryManager>();


            builder.Services.AddScoped<IGarnitureDal, EfGarnitureDal>();
            builder.Services.AddScoped<IGarnitureService, GarnitureManager>();

            builder.Services.AddScoped<IBurgerGarnitureMappingDal, EfBurgerGarnitureMappingDal>();
            builder.Services.AddScoped<IBurgerGarnitureMappingService, BurgerGarnitureMappingManager>();

            builder.Services.AddScoped<IOrderDal, EfOrderDal>();
            builder.Services.AddScoped<IOrderService, OrderManager>();

            builder.Services.AddScoped<IMenuOrderMappingDal, EfMenuOrderMappingDal>();
            builder.Services.AddScoped<IMenuOrderMappingService, MenuOrderMappingManager>();

            builder.Services.AddScoped<IBurgerOrderMappingDal, EfBurgerOrderMappingDal>();
            builder.Services.AddScoped<IBurgerOrderMappingService, BurgerOrderMappingManager>();

            builder.Services.AddScoped<IBurgerMenuMappingDal, EfBurgerMenuMappingDal>();
            builder.Services.AddScoped<IBurgerMenuMappingService, BurgerMenuMappingManager>();

            builder.Services.AddScoped<IMenuByProductMappingDal, EfMenuByProductMappingDal>();
            builder.Services.AddScoped<IMenuByProductMappingService, MenuByProductMappingManager>();

            builder.Services.AddScoped<IOrderByProductMappingDal, EfOrderByProductMappingDal>();
            builder.Services.AddScoped<IOrderByProductMappingService, OrderByProductMappingManager>();

            builder.Services.AddScoped<ICustomerMessageDal, EfCustomerMessageDal>();
            builder.Services.AddScoped<ICustomerMessageService, CustomerMessageManager>();

            builder.Services.AddScoped<IBasketService, BasketManager>();

            builder.Services.AddScoped<IBasketSessionHelper, BasketSessionHelper>();
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            builder.Services.AddScoped<IParameterDal, EfParameterDal>();
            builder.Services.AddScoped<IParameterService, ParameterManager>();
            builder.Services.AddScoped<IParameterSessionHelper, ParameterSessionHelper>();

            builder.Services.AddSession();

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = "/Login/Index";
                //options.AccessDeniedPath = "/Book/Index";

            });


            //builder.Services.AddAuthentication();
            builder.Services.AddAuthorization();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStatusCodePagesWithRedirects("/Error/ErrorPage/?{0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Default}/{action=Index}/{id?}");

            app.Run();
        }
    }
}