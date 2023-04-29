

using CarsList.Logic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
var car = new Linkedlist<Cars>();

car.Add(new Cars("BMW", 2021, "iX4x4", 100000000, "blak"));
car.Add(new Cars("Mercedes-Benz", 2023, "Clase G", 120000000, "white"));
car.Add(new Cars("Mercedes-Benz", 2015, "Clase G", 120000000, "red"));
car.Add(new Cars("Ford", 2022, "Focus", 85000000, "blue"));
car.Add(new Cars("BMW", 2024, "i4 Berlina", 99000000, "orenge"));
car.Add(new Cars("Ford", 2015, "Fiesta", 65400000, "blak"));
car.Add(new Cars("Audi", 2016, "A1", 115000000, "green"));
car.Add(new Cars("BMW", 2022, "SUV", 91450000000, "yellow"));
car.Add(new Cars("Lexus", 2024, "CT", 77000000, "purple"));
car.Add(new Cars("Mercedes-Benz", 2017, "SL R129", 88000000, "white"));
car.Add(new Cars("Audi", 2011, "A3", 145000000, "blue"));
car.Add(new Cars("Opel", 2021, "Astra", 60000000, "grey"));

Console.WriteLine(" cars available ");
Console.WriteLine(car);

var minMax = car.GetMinMaxPrice(car);
Console.WriteLine("cheaper car");
Console.WriteLine(minMax[0]);
Console.WriteLine("Most expensive car");
Console.WriteLine(minMax[1]);