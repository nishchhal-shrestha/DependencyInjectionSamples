using DependencyInjectionSamples.SharedLib.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSamples.SharedLib.Core
{
    public interface IOrderService
    {
        public Task<OrderDto> PlaceOrder(OrderDto orderDto);
    }
}
