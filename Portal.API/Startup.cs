using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.Subscriptions;
using HotChocolate.Types;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Portal.API.Context;
using Portal.API.GraphQL.Queries;
using Portal.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllers();

            services.AddGraphQLServer()
            .AddQueryType<RootQuery>()
            .AddProjections();
            
             
            services.AddDbContext<AduasisContext>(options => options.UseSqlServer(Configuration["SqlServerConnectionString"]));
            services.AddAuthorization();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("wW7pPV7ngghwWxpNLc7N8SQPhjXcPQEMtHwpfiknpJqkr5aX1kSDsNnndqWLXWkx"));
           
            //services.AddAuthentication(HotChocolate.AspNetCore.Authorization);

            /*
            services.AddSwaggerGen(c =>
            {
              //  c.SwaggerDoc("v1", new OpenApiInfo { Title = "Portal.API", Version = "v1" });
            });*/

            //.AddQueryType<Query>()
            //.AddMutationType<Mutation>()
            //.AddSubscriptionType<Subscription>();

        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseWebSockets();
            app.UseRouting();
            app.UseEndpoints(endpoint => endpoint.MapGraphQL());

            /*
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseGraphQLPlayground();

                //app.UseSwagger();
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Portal.API v1"));
            }


            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });*/
        }

    }
}
