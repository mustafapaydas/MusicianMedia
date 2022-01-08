using System;
using System.Collections.Generic;
using System.Text;
using Core.CrossCoutingConcerns.Caching;
using Core.CrossCoutingConcerns.Caching.InMemoryCache;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Core.DependencyResolvers
{
    public class CoreModule:ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<ICacheManager,InMemoryCacheManager>();
        }
    }
}
