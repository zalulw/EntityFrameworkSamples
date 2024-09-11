using Vehicles.Database;
using Vehicles.Database.Entities;

using var dbContext = new ApplicationDBContext();

var sigmobil = new VehicleEntity
{
    ChassisNumber = "sigmakgleéajgbn19",
    EngineNumber = "fe",
    LicensePlate = "SIGM412",
    numOfDoors = 3,
    Power = 120,
    Weight = 1400
};

await dbContext.Vehicles.AddAsync(sigmobil);
await dbContext.SaveChangesAsync();

Console.ReadKey();