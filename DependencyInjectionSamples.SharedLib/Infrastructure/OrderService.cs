using DependencyInjectionSamples.SharedLib.Core;
using DependencyInjectionSamples.SharedLib.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSamples.SharedLib.Infrastructure
{
    public class OrderService : IOrderService
    {
        public async Task<OrderDto> PlaceOrder(OrderDto orderDto)
        {
            return orderDto;
        }
    }
}
