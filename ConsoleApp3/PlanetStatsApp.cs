using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsPlanetsStats
{
    using StarWarsPlanetsStats;
    using System.Numerics;
    using System.Reflection.Metadata.Ecma335;
    using System.Text.Json.Nodes;
    using UltimateCSharpMasterClass;

    public class PlanetStatsApp
    {
        public IApiReader ApiReader { get; set; }

        public PlanetsStatsReader Statsreader { get; }

        public PlanetsRepository PlanetsRepository { get; }

        public PlanetStatsApp(PlanetsRepository repository)
        {
            PlanetsRepository = repository;
        }


        public async Task Run()
        {
            
            List<DTOs> planets = new List<DTOs>();
            while (planets.Count == 0)
            {
                planets = await PlanetsRepository.GetTenFirstPlanetsAsync();
            }
            var _planets = new List<Planet>();

            if (planets is not null)
            {
                foreach (var planet in planets)
                {
                    Console.WriteLine((Planet)planet);
                    _planets.Add((Planet)planet);
                }
            }
            Console.WriteLine("");
            var ui = new PlanetsUI(planets);
            var funcpropdictionary = new Dictionary<string, Func<Planet, int?>>();

            funcpropdictionary["surfacewater"] = planet => planet.SurfaceWater;
            funcpropdictionary["diameter"] = planet => planet.Diameter;
            funcpropdictionary["population"] = planet => planet.Population;

            //ui.PromptToSelect();
            Console.WriteLine("Select an option :");
            Console.WriteLine("diameter");
            Console.WriteLine("population");
            Console.WriteLine("surfacewater");


            var option = PlanetsUI.ReadOption();
             
           
           
            ShowStats(_planets, option, funcpropdictionary[option]);



           
            
            //var option = ui.ReadOption();
            

            //ui.PrintStats(planets);
            //ui.PrintSelectedStats(option);

            Console.ReadKey();
            
        //    foreach (Root data in planets)
        //    {
        //        await Console.Out.WriteLineAsync($"{data.name}  {data.diameter}  {data.surface_water}  {data.population}");
        //    }
        }

        private void ShowStats(List<Planet> planets, string? option, Func<Planet, int?> lambdaexpression)
        {
           
                var maxplanet = planets.MaxBy(lambdaexpression);
                Console.WriteLine($"Max {option} is " + maxplanet.Diameter + $"({maxplanet.Name})");
            
        }
    }
}
