using NguyenVanQuyThuongmaidientu.Server.Services.PaymentService;
using NguyenVanQuyThuongmaidientu.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace NguyenVanQuyThuongmaidientu.Client.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        private readonly HttpClient _http;

        public PaymentService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Payment> CreatePaymentAsync(Payment payment)
        {
            var response = await _http.PostAsJsonAsync("api/payment", payment);
            if (response.IsSuccessStatusCode)
            {
                var paymentResponse = await response.Content.ReadFromJsonAsync<Payment>();
                return paymentResponse ?? new Payment();
            }

            return new Payment();
        }
    }
}
