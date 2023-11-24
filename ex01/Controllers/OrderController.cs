
using AutoMapper;
using DTO;
using Entytess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using servies;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMapper map;
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService, IMapper _map)
        {
            _orderService = orderService;
            map = _map;

        }
        [HttpPost]
        public async Task Post([FromBody] OrderDto order)
        {

            Order ord = map.Map<OrderDto,Order >(order);

            await _orderService.CreateNewOrder(ord);
           

         
            return;
        }
        }
}
 