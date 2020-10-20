using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Nextoo.MeuPlano.DAL.Commom.Interface;
using Nextoo.MeuPlano.DAL.Connection;
using Nextoo.MeuPlano.DAL.Repository.Planos;
using Nextoo.MeuPlano.DAL.Repository.Planos.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nextoo.MeuPlano.DAL.Commom.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<IPlanoRepository, PlanoRepository>();
            services.AddScoped<ConnectionContext>();
        }
    }
}
