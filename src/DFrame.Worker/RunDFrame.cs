using ConsoleAppFramework;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace DFrame
{
    public static class DFrameAppHostBuilderExtensions
    {
        public static Task RunDFrameWorkerAsync(this IHostBuilder hostBuilder, string controllerAddress)
        {
            return RunDFrameWorkerAsyncCore(hostBuilder, new DFrameWorkerOptions(controllerAddress), (_, __) => { });
        }

        public static Task RunDFrameWorkerAsync(this IHostBuilder hostBuilder, DFrameWorkerOptions options)
        {
            return RunDFrameWorkerAsyncCore(hostBuilder, options, (_, __) => { });
        }

        public static Task RunDFrameWorkerAsync(this IHostBuilder hostBuilder, Action<DFrameWorkerOptions> configureOptions)
        {
            return RunDFrameWorkerAsyncCore(hostBuilder, new DFrameWorkerOptions(), (_, x) => configureOptions(x));
        }

        public static Task RunDFrameWorkerAsync(this IHostBuilder hostBuilder, Action<HostBuilderContext, DFrameWorkerOptions> configureOptions)
        {
            return RunDFrameWorkerAsyncCore(hostBuilder, new DFrameWorkerOptions(), configureOptions);
        }

        static async Task RunDFrameWorkerAsyncCore(IHostBuilder builder, DFrameWorkerOptions options, Action<HostBuilderContext, DFrameWorkerOptions> configureOptions)
        {
            builder
                .ConfigureServices((hostContext, services) =>
                {
                    configureOptions(hostContext, options);
                    services.AddSingleton(options);
                });

            ConsoleApp.ServiceProvider = builder.Build().Services;

            var app = ConsoleApp.Create();
            app.Add<DFrameWorkerApp>();

            var args = Environment.GetCommandLineArgs()[1..];
            await app.RunAsync(args);
        }
    }
}