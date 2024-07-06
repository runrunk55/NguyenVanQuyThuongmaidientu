using Microsoft.AspNetCore.Mvc;
using NguyenVanQuyThuongmaidientu.Server.Services.PaymentService;
using NguyenVanQuyThuongmaidientu.Shared;
using System.Threading.Tasks;

namespace NguyenVanQuyThuongmaidientu.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePayment([FromBody] Payment payment)
        {
            if (payment == null)
            {
                return BadRequest("Payment data is null.");
            }

            try
            {
                var result = await _paymentService.CreatePaymentAsync(payment);
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Log the exception (you might want to use a logging library for this)
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
