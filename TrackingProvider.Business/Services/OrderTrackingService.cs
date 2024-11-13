
using TrackingProvider.Business.Interfaces;
using TrackingProvider.Data.Interfaces;
using TrackingProvider.Domain.Enums;
using TrackingProvider.Domain.Models;

namespace TrackingProvider.Business.Services;
public class OrderTrackingService : IOrderTrackingService
{
    private readonly IOrderRepository _orderRepository;

    public OrderTrackingService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }
    public TrackingInfo GetOrderTrackingInfo(int orderId)
    {
        try
        {
            return _orderRepository.GetTrackingInfo(orderId);
        }
        catch 
        {
            return new TrackingInfo
            {
                

                OrderId = orderId,
                Status = OrderStatusNotification.NotFound,
                EstimatedDelivery = DateTime.MinValue
            };
        }    
    }
}
