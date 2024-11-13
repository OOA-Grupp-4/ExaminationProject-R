using TrackingProvider.Data.Interfaces;
using TrackingProvider.Domain.Enums;
using TrackingProvider.Domain.Models;

namespace TrackingProvider.Data.Services;

public class OrderRepository : IOrderRepository
{
    //Fick hjälp av Chattgpt att göra en switch och hur jag skulle bygga den
    public TrackingInfo GetTrackingInfo(int orderId)
    {
        return orderId switch
        {
            1 => new TrackingInfo { OrderId = 1, Status = OrderStatusNotification.Shipped, EstimatedDelivery = DateTime.Now.AddDays(2) },
            2 => new TrackingInfo { OrderId = 2, Status = OrderStatusNotification.Processing, EstimatedDelivery = DateTime.Now.AddDays(5) },
            3 => new TrackingInfo { OrderId = 3, Status = OrderStatusNotification.Delivered, EstimatedDelivery = DateTime.Now.AddDays(-1) },
            _ => new TrackingInfo { OrderId = orderId, Status = OrderStatusNotification.UnknownStatus, EstimatedDelivery = DateTime.MinValue }
        };
    }
}
