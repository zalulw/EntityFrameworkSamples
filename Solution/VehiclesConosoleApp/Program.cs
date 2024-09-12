using Microsoft.EntityFrameworkCore;
using Vehicles.Database;
using Vehicles.Database.Entities;

using var dbContext = new ApplicationDBContext();

//adat hozzaadasa a tablahoz
/*var sigmobil = new VehicleEntity
{
    ChassisNumber = "fhgbvjakvmeth3421",
    EngineNumber = "az",
    LicensePlate = "AHF1245",
    numOfDoors = 4,
    Power = 90,
    Weight = 1000,
    ColorID = 2
};

await dbContext.Vehicles.AddAsync(sigmobil);
await dbContext.SaveChangesAsync();*/

//rekord modositasa
/*var vehicle = await dbContext.Vehicles.FindAsync((int)1); //vagy .SingleOrDefaultAsync();
vehicle.ChassisNumber = "11111111111111111";
await dbContext.SaveChangesAsync();*/

//rekord torlese
/*var vehicle = await dbContext.Vehicles.FindAsync((int)1);
dbContext.Vehicles.Remove(vehicle);*/

//adatok kiolvasasa az adatbazisbol
var vehicles = await dbContext.Vehicles.Include(v => v.Color).ToListAsync(); //gyujtemeny ahol az adatok vannak
PrintVehiclesOnConsole(vehicles);


Console.ReadKey();


void PrintVehiclesOnConsole(ICollection<VehicleEntity> vehicles)
{
    foreach (var vehicle in vehicles)
    {
        Console.WriteLine($"{vehicle.LicensePlate} {vehicle.Color.Name}");
    }
}