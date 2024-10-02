using Gateways.Business.Contracts.Entities;
using Gateways.Business.Contracts.Enums;

namespace Gateways.Data.Implementations;
public class DatabaseInitializer
{
    public static void InitializeDatabase(ObjectContext context)
    {
        var gateways = new List<Gateway>
        {
            new() { Id = "GW001", Name = "Gateway 1" , IPv4 = "192.168.87.1" },
            new() { Id = "GW002", Name = "Gateway 2" , IPv4 = "192.168.88.1" },
            new() { Id = "GW003", Name = "Gateway 3" , IPv4 = "192.168.89.1" },
        };

        var devices = new List<Device>
        {
            new() { Id = 1, Vendor = "Device 1", GatewayId = gateways[0].Id ,
            DateCreated = DateTime.UtcNow, Status = DeviceStatus.Online},
            new() { Id = 2, Vendor = "Device 2", GatewayId = gateways[0].Id ,
            DateCreated = DateTime.UtcNow, Status = DeviceStatus.Offline},
            new() { Id = 3, Vendor = "Device 3", GatewayId = gateways[0].Id ,
            DateCreated = DateTime.UtcNow, Status = DeviceStatus.Offline},
            new() { Id = 4, Vendor = "Device 4", GatewayId = gateways[0].Id ,
            DateCreated = DateTime.UtcNow, Status = DeviceStatus.Online},
            new() { Id = 5, Vendor = "Device 5", GatewayId = gateways[0].Id ,
            DateCreated = DateTime.UtcNow, Status = DeviceStatus.Online},
            new() { Id = 6, Vendor = "Device 6", GatewayId = gateways[0].Id ,
            DateCreated = DateTime.UtcNow, Status = DeviceStatus.Offline},
            new() { Id = 7, Vendor = "Device 7", GatewayId = gateways[0].Id ,
            DateCreated = DateTime.UtcNow, Status = DeviceStatus.Online},
            new() { Id = 8, Vendor = "Device 8", GatewayId = gateways[0].Id ,
            DateCreated = DateTime.UtcNow, Status = DeviceStatus.Online},
            new() { Id = 9, Vendor = "Device 9", GatewayId = gateways[0].Id ,
            DateCreated = DateTime.UtcNow, Status = DeviceStatus.Online},
            new() { Id = 10, Vendor = "Device 10", GatewayId = gateways[0].Id ,
            DateCreated = DateTime.UtcNow, Status = DeviceStatus.Offline},
            new() { Id = 11, Vendor = "Device 11", GatewayId = gateways[1].Id },
            new() { Id = 12, Vendor = "Device 12", GatewayId = gateways[1].Id },
        };

        foreach (Gateway gateway in gateways)
        {
            context.Gateways.Add(gateway);
        }

        foreach (Device device in devices)
        {
            context.Devices.Add(device);
        }

        context.SaveChanges();
    }
}
