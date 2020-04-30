using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MediaMinistryManagement.Models;

namespace MediaMinistryManagement
{
    public class Startup
    {
        private readonly string _connection = "Data Source=mediaministry.database.windows.net;Initial Catalog = \"Media Ministry\";Persist Security Info=True;User ID = arandlemiller97;Password=AMrw2697";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region DATABASE CONTEXTS
            services.AddDbContext<CustomerContext>(opt => opt.UseSqlServer(_connection));
            services.AddDbContext<ListenerContext>(opt => opt.UseSqlServer(_connection));
            services.AddDbContext<InventoryContext>(opt => opt.UseSqlServer(_connection));
            services.AddDbContext<OrderSummaryContext>(opt => opt.UseSqlServer(_connection));
            services.AddDbContext<CompletedOrderSummaryContext>(opt => opt.UseSqlServer(_connection));
            services.AddDbContext<OrdersContext>(opt => opt.UseSqlServer(_connection));
            services.AddDbContext<Order_CountsContext>(opt => opt.UseSqlServer(_connection));
            services.AddDbContext<Completed_OrdersContext>(opt => opt.UseSqlServer(_connection));
            services.AddDbContext<Completed_Order_CountsContext>(opt => opt.UseSqlServer(_connection));
            #endregion
            services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }

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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
