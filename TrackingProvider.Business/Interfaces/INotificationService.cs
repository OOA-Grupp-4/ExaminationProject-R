using TrackingProvider.Domain.Enums;
using TrackingProvider.Domain.Models;

namespace TrackingProvider.Business.Interfaces;
public interface INotificationService
{
    OrderStatusNotification GetOrderStatusNotification(TrackingInfo trackingInfo);
}