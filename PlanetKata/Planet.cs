namespace PlanetKata
{
    public class Planet : IPlanet
    {
        public Planets Name { get; set; }
        public double Mass { get; set; }
        public string Material { get; set; }
        public int AmountOfMoons { get; set; }
        public bool HasRings { get; set; }

        public override string ToString()
        {
            string hasRings;

            if (HasRings == true)
            {
                hasRings = "This planet has rings";
            }
            else
            {
                hasRings = "This planet does not have rings";
            }

            string hasMoons;

            if (AmountOfMoons == 0)
            {
                hasMoons = "This planet does not have any moon";
            }
            else

                hasMoons = $"The amount of moons for this planet is {AmountOfMoons}";


            return $"The name of the planet: {Name}\nThe total mass: {Mass}\n" +
            $"Type of material: {Material}\n{hasMoons}\n{hasRings}\n";
        }

        public int CompareTo(IPlanet other)
        {
            if (this.Mass != other.Mass)
            {
                return this.Mass.CompareTo(other.Mass);
            }
            else if (this.Name != other.Name)
            {
                return this.Name.CompareTo(other.Name);
            }
            else if (this.Material != other.Material)
            {
                return this.Material.CompareTo(other.Material);
            }
            else if (this.AmountOfMoons != other.AmountOfMoons)
            {
                return this.AmountOfMoons.CompareTo(other.AmountOfMoons);
            }

            return this.HasRings.CompareTo(other.HasRings);
        }

        public bool Equals(IPlanet other)
        {
            return (this.Name, this.Mass, this.Material, this.AmountOfMoons, this.HasRings) == (other.Name, other.Mass, other.Material, other.AmountOfMoons, other.HasRings);
        }

        public override bool Equals(object? obj) => Equals(obj as IPlanet);
        public override int GetHashCode() => (Name, Mass, Material, AmountOfMoons, HasRings).GetHashCode();

        public void RandomInit()
        {
            var rnd = new Random();
            bool isCorrect = false;

            while (!isCorrect)
            {
                try
                {
                    double[] _mass = { 0.06, 0.81, 1.0, 0.11, 317.83, 95.16, 14.54, 17.15, 0.0022 };
                    string[] _material = "Rock Gas Helium Hydrogen Water".Split(' ');
                    int[] _amountOfMoons = { 0, 0, 1, 2, 80, 83, 27, 14 };
                    bool[] _hasRings = { true, false };

                    this.Name = (Planets)rnd.Next((int)Planets.Mercury, (int)Planets.Pluto + 1);
                    this.Mass = _mass[rnd.Next(0, _mass.Length)];
                    this.Material = _material[rnd.Next(0, _material.Length)];
                    this.AmountOfMoons = _amountOfMoons[rnd.Next(0, _amountOfMoons.Length)];
                    this.HasRings = _hasRings[rnd.Next(0, _hasRings.Length)];

                }
                catch { }

                isCorrect = true;

            }


        }



        public static class Factory
        {
            public static IPlanet CreateRandomPlanet()
            {
                var planet = new Planet();
                planet.RandomInit();
                return planet;

            }
        }

        public Planet() { }
    }
}
