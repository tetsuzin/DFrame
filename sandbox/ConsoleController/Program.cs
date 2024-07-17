using DFrame;
using MessagePipe;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMessagePipe();
builder.Services.AddHostedService<ConsoleController.EventHandler>();

await builder.RunDFrameControllerAsync(opt =>
{
    opt.Title = "foo";
});




//builder.Logging.ClearProviders();
//builder.Logging.SetMinimumLevel(LogLevel.Information);
//builder.Logging.AddZLoggerConsole(options => { });

