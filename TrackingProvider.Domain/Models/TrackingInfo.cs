

using TrackingProvider.Domain.Enums;

namespace TrackingProvider.Domain.Models;
public class TrackingInfo
{
    public int OrderId { get; set; }
    public DateTime EstimatedDelivery { get; set; }
    public string Product { get; set; } = null!;
    public OrderStatusNotification Status { get; set; } = OrderStatusNotification.UnknownStatus;

}
