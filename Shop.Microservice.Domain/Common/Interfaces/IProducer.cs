using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Microservice.Domain.Common.Interfaces
{
    public interface IProducer
    {
        void Produce(string message, string topic, string userName, string email);
    }
}
