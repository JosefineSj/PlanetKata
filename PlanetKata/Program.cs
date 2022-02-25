// See https://aka.ms/new-console-template for more information
using PlanetKata;

Console.WriteLine("CREATING A PLANET");
Console.WriteLine();
var planet1 = Planet.Factory.CreateRandomPlanet();
Console.WriteLine(planet1);

Console.WriteLine("CREATING A LIST OF SEVERAL PLANETS");
Console.WriteLine();
var planetList = PlanetList.Factory.CreateSeveralPlanets(20);
Console.WriteLine(planetList);

Console.Write("AMOUNT OF PLANETS WITH RINGS: ");
Console.WriteLine(planetList.AmountOfPlanetsWithRings());

Console.WriteLine();
Console.Write("AMOUNT OF PLANETS WITH GAS: ");
Console.WriteLine(planetList.CountGasPlanets("Gas"));

Console.WriteLine();
Console.Write("TOTAL AMOUNT OF PLANETS: ");
Console.WriteLine(planetList.CountNumberOfPlanets());

Console.WriteLine();
Console.Write("TOTAL AMOUNT OF MOONS: ");
Console.WriteLine(planetList.TotalAmountOfMoons());

Console.WriteLine();
Console.WriteLine("PLANETS SORTED BY MASS");
planetList.SortPlanets();
Console.WriteLine(planetList);

Console.WriteLine();
Console.WriteLine($"THE PLANET ON INDEX [0]: \n{planetList[0]}");
Console.WriteLine($"THE PLANET ON INDEX [1]: \n{planetList[1]}");


