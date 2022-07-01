using MassTransit;
using Microsoft.AspNetCore.Mvc;
using RabbitMQGateway.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQGateway.Controllers
{
    [Route("/[controller]")]
    public class ValueController : ControllerBase
    {
        readonly IPublishEndpoint _publishEndpoint;

        public ValueController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        [HttpGet("{value}")]
        public async Task<ActionResult> Post(string value)
        {
            await _publishEndpoint.Publish<ValueEntered>(new
            {
                Value = value
            });

            return Ok();
        }
    }
}
