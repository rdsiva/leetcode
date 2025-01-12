// See https://aka.ms/new-console-template for more information
var parking = new ParkingSystem(1,1,0);

Console.WriteLine($"[{parking.AddCar(1)},{parking.AddCar(2)}, {parking.AddCar(3)},{parking.AddCar(1)}]");
Console.ReadLine();