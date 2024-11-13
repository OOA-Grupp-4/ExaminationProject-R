using TrackingProvider.Business.Services;
using TrackingProvider.Domain.Enums;
using TrackingProvider.Domain.Models;

namespace TrackingProvider.Tests.BusinessServiceTests;
public class NotificationService_Tests
{
    [Fact]
    public void GetOrderStatusNotification_ShouldReturnShippedWhenStatusIsSetToShipped()
    {
        // Arrange
        var notificationService = new NotificationService();
        var trackingInfo = new TrackingInfo
        {
            OrderId = 1,
            Status = OrderStatusNotification.Shipped,
        };

        // Act
        var result = notificationService.GetOrderStatusNotification(trackingInfo); 

        // Assert
        Assert.Equal(OrderStatusNotification.Shipped, result);
    }
}
