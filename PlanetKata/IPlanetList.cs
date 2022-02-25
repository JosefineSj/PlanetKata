using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetKata
{
    public interface IPlanetList
    {
        IPlanet this[int idx] { get; }
        int CountNumberOfPlanets();

        int CountGasPlanets(string material);

        int AmountOfPlanetsWithRings();

        int TotalAmountOfMoons();

        void SortPlanets();
    }
}
