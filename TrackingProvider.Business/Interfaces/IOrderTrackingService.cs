using TrackingProvider.Domain.Models;

namespace TrackingProvider.Business.Interfaces;

public interface IOrderTrackingService
{
    TrackingInfo GetOrderTrackingInfo(int orderId);
}