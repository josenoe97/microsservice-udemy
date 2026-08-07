using System.Threading.Tasks;
using GeekShopping.OrderAPI.Model;

namespace GeekShopping.OrderAPI.Repository
{
    public interface IOrderRepository
    {
        Task<bool> AddOrder(OrderHeader header);
        Task<bool> UpdateOrderPaymentStatus(long orderHeaderId, bool status);
    }
}
