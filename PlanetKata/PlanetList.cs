using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetKata
{
    public class PlanetList : IPlanetList
    {
        List<IPlanet> _planets = new List<IPlanet>();

        public override string ToString()
        {
            int num = 1;
            string sRet = "";
            for (int i = 0; i < _planets.Count; i++)
            {
                sRet += $"PLANET {num}\n{_planets[i]}\n";
                if ((i + 1) % 5 == 0)
                {
                    sRet += "\n";

                }
                num++;
            }
            return sRet;

        }
        public IPlanet this[int idx] => this._planets[idx];

        public int AmountOfPlanetsWithRings()
        {
            int count = 0;
            foreach (var item in _planets)
            {
                if (item.HasRings == true)
                {
                    count++;
                }

            }
            return count;
        }

        public int CountGasPlanets(string material)
        {
            int count = 0;
            foreach (var item in _planets)
            {
                if (item.Material.Contains(material))
                {
                    count++;
                }
            }
            return count;
        }

        public int CountNumberOfPlanets() => this._planets.Count;

        public void SortPlanets() => this._planets.Sort();

        public int TotalAmountOfMoons()
        {
            int moonCount = 0;
            for (int i = 0; i < _planets.Count; i++)
            {
                moonCount += _planets[i].AmountOfMoons;
            }
            return moonCount;
        }

        public static class Factory
        {
            public static IPlanetList CreateSeveralPlanets(int nrOfPlanets)
            {
                var planet = new PlanetList();
                for (int i = 0; i < nrOfPlanets; i++)
                {
                    planet._planets.Add(Planet.Factory.CreateRandomPlanet());
                }
                return planet;
            }
        }

        public PlanetList() { }
    }
}
