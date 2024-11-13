

using TrackingProvider.Business.Services;
using TrackingProvider.Data.Services;
using TrackingProvider.Domain.Enums;
using TrackingProvider.Domain.Models;

namespace TrackingProvider.Tests.BusinessServiceTests;
public class OrderTrackingService_Tests
{
    [Fact]
    public void GetOrderTrackingInfo_ShouldReturnCorrectTrackingInfo_ForExistingOrder()
    {
        // Arrange
        var orderRepository = new OrderRepository();
        var orderTrackingService = new OrderTrackingService(orderRepository);
        var expectedDeliveryDate = DateTime.Now.AddDays(2);
        var trackingInfo = new TrackingInfo
        {
            OrderId = 1,
           
        };

        // Act
        var result = orderTrackingService.GetOrderTrackingInfo(trackingInfo.OrderId);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(1, result.OrderId);
        Assert.Equal(OrderStatusNotification.Shipped, result.Status);
        Assert.Equal(expectedDeliveryDate.Date, result.EstimatedDelivery.Date);
    }
}
