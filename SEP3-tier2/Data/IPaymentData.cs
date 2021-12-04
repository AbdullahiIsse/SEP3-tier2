using System.Threading.Tasks;
using SEP3_tier2.Models;

namespace SEP3_tier2.Data
{
    public interface IPaymentData
    {
        void AddPayment(Payment payment);

        Task<Payment> GetPaymentById(long id);
    }
}