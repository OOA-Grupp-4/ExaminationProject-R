using TrackingProvider.Domain.Models;

namespace TrackingProvider.Data.Interfaces;
public interface IOrderRepository
{
    TrackingInfo GetTrackingInfo(int orderId);
}