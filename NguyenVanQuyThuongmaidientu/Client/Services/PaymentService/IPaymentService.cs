using System.Threading.Tasks;
using NguyenVanQuyThuongmaidientu.Shared;

namespace NguyenVanQuyThuongmaidientu.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        Task<Payment> CreatePaymentAsync(Payment payment);
    }
}
