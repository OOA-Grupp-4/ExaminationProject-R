

using TrackingProvider.Business.Interfaces;
using TrackingProvider.Domain.Enums;
using TrackingProvider.Domain.Models;

namespace TrackingProvider.Business.Services;
public class NotificationService : INotificationService
{

    public OrderStatusNotification GetOrderStatusNotification(TrackingInfo trackingInfo)
    {
        if (trackingInfo == null)
        {
            return OrderStatusNotification.NotFound;
        }

        // Returnerar statusen från TrackingInfo om den finns
        return trackingInfo.Status;
    }
}


