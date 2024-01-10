using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Microservice.Domain.Common
{
    public interface IEntity
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        Guid Id { get; set; }
    }
}
