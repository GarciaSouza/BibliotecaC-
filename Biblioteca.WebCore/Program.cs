using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using SimpleInjector;
using Biblioteca.Domain.Repositories;
using Biblioteca.NH.Repositories;

namespace Biblioteca.WebCore
{
    public class Program
    {
        public static Container Container;

        public static void Main(string[] args)
        {
            Container = new Container();
            Container.Register<ILivroRepository, LivroRepository>();
            Container.Register<IRevistaRepository, RevistaRepository>();
            Container.Verify();

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            host.Run();
        }
    }
}
