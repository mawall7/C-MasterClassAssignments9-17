using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using static StarWarsPlanetsStats.PlanetStatsApp;

namespace StarWarsPlanetsStats
{
    public class PlanetsRepository
    {

        
        public PlanetsStatsReader StatsReader { get; }

        public PlanetsRepository(PlanetsStatsReader statsReader)
        {
            
            StatsReader = statsReader;
        }

        public async Task<List<DTOs>> GetTenFirstPlanetsAsync() //get firs 10 planets
        {
            List<DTOs> list = new List<DTOs>();
            const int reads = 10;
            for (int i = 1; i <= reads; i++)
            {
                string? jsondata = null;
                while(jsondata is null) 
                {
                   jsondata =  await StatsReader.Read(i);
                }
                DTOs dataasrootrecord = System.Text.Json.JsonSerializer.Deserialize<DTOs>(jsondata); //obs single responsibility
                list.Add(dataasrootrecord);

                
            }
            return list;
               
            
        }


    }

    public readonly record struct Planet
    {

        public string Name { get; }

        public int Diameter { get; }

        public int? SurfaceWater { get; }
        
        public int? Population { get; }
        public Planet(string name, int diameter, int? surfaceWater, int? population)
        {
            if (name is null)
            {
                throw new NullReferenceException("name of Planet cannot be null");
            }
            else
            {
                Name = name;
                SurfaceWater = surfaceWater;
                Diameter = diameter;
                Population = population;
            }

        }

       
        public static explicit operator Planet(DTOs v)
        {
            int surfacewater; 
            int population;
            Int32.TryParse(v.population, out population);
            Int32.TryParse(v.surface_water, out surfacewater);
            int diameter = Int32.Parse(v.diameter);
            return new Planet(v.name, diameter, surfacewater, population);
        }
    }
}
