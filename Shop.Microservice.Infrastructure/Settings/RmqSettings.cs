using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Microservice.Infrastructure.Settings
{
    public class RmqSettings
    {
        public string Host { get; set; }
        public string VHost { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
