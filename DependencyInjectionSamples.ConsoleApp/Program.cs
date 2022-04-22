// See https://aka.ms/new-console-template for more information
using DependencyInjectionSamples.SharedLib.Core;
using DependencyInjectionSamples.SharedLib.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");
var services = new ServiceCollection();
services.AddScoped<IOrderService, OrderService>();
var serviceProvider = services.BuildServiceProvider();

using(var scope = serviceProvider.CreateScope())
{
    var orderService = scope.ServiceProvider.GetRequiredService<IOrderService>();
    await orderService.PlaceOrder(new DependencyInjectionSamples.SharedLib.Dto.OrderDto());
}