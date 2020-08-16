using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MediaMinistryManagement.Models;
//using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using BasicAuthentication;

namespace MediaMinistryManagement
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string _conn = string.Format(Configuration["ConnectionStrings:MediaMinistry"], Configuration["ConnectionStrings:UserID"], Configuration["ConnectionStrings:Password"]);
            Console.WriteLine(_conn);
            #region DATABASE CONTEXTS
            services.AddDbContext<CustomerContext>(opt => opt.UseSqlServer(_conn));
            services.AddDbContext<InventoryContext>(opt => opt.UseSqlServer(_conn));
            services.AddDbContext<OrderSummaryContext>(opt => opt.UseSqlServer(_conn));
            services.AddDbContext<CompletedOrderSummaryContext>(opt => opt.UseSqlServer(_conn));
            services.AddDbContext<OrdersContext>(opt => opt.UseSqlServer(_conn));
            services.AddDbContext<Order_CountsContext>(opt => opt.UseSqlServer(_conn));
            services.AddDbContext<Completed_OrdersContext>(opt => opt.UseSqlServer(_conn));
            services.AddDbContext<Completed_Order_CountsContext>(opt => opt.UseSqlServer(_conn));
            services.AddDbContext<ListenerContext>(opt => opt.UseSqlServer(_conn));
            #endregion
            services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Latest);
            //services.AddRazorPages();
        }

        #region Obselete
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [System.Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedFor | Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedProto
            });
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseMvc();
        }
        #endregion

        #region Updated
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // This is the new updated way to do the method above
        /*public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedFor | Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedProto
            });

            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }*/
        #endregion
    }
}
