using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQGateway.Objects
{
    public class SubmitOrder
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
