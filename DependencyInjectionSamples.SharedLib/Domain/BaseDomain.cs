using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSamples.SharedLib.Domain
{
    public class BaseDomain<T>
    {
        public T Id { get; set; }
    }
}
