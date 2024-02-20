using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static StarWarsPlanetsStats.PlanetStatsApp;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StarWarsPlanetsStats
{
    public class PlanetsUI
    {
        private readonly List<DTOs> _planets;
        private int _margin = 15;

        public PlanetsUI(List<DTOs> planets)
        {
            _planets = planets;
        }
        public void PrintStats(List<DTOs> planets)
        {
            throw new NotImplementedException();        
            //StringBuilder builder = new StringBuilder();

            //var tableheader = planets.Select(item => $"{item.GetType().GetProperty(nameof(DTOs.name)).Name.Marginized(15)}|{item.GetType().GetProperty(nameof(DTOs.diameter)).Name.Marginized(15)}|{item.GetType().GetProperty(nameof(DTOs.surface_water)).Name.Marginized(15)}|{item.GetType().GetProperty(nameof(DTOs.population)).Name.Marginized(15)}").FirstOrDefault();

            
            //var planetstable = planets.Select(item => $"{item.name}|{item.diameter}|{item.surface_water}|{item.population.ToString()}" + System.Environment.NewLine);
            //foreach (var item in planets) 
            //{
            //    foreach (var key in planetsdictionary.Keys) 
            //    {
            //        Console.Write("{0,-15}",  $"|{planetsdictionary[key].Invoke}");
            //    }
            //    Console.WriteLine();
            
            //}
            ////Console.WriteLine(tableheader);
            //for (int i = 0; i < tableheader.Count(); i++)
            //{
            //    Console.Write("-");
            //}
            //Console.WriteLine();

            //foreach (var item in planetstable)
            //{
            //    Console.WriteLine(item);
            //}            //{

            //    string namestat = StringFormatedWithMargin(data.name);
            //    string diameterstat = StringFormatedWithMargin(data.diameter);
            //    string surfacewaterstat = StringFormatedWithMargin(data.surface_water);
            //    string popululationstat = StringFormatedWithMargin(data.population);
            //    Console.WriteLine(namestat + diameterstat + surfacewaterstat + popululationstat);
            //    builder.Clear();
            //}
        }




        public string StringFormatedWithMargin(string stringToFormat)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(stringToFormat);
            int stepsmissingtomargin = _margin - stringToFormat.Count();
            for (int i = 0; i < stepsmissingtomargin; i++)
            {
                builder.Append(" ");
            }

            return builder.ToString();
        }

        internal void PromptToSelect()
        {
            var newline = System.Environment.NewLine;
            Console.WriteLine("Select the stats what you are interested in" + newline + "population" + newline + "diameter" + "surfacewater" + newline);
        }

        public static string ReadOption()
        {
            var selectedoption = (string)default;
            bool optionSelected = false;
            do
            {
                selectedoption = Console.ReadLine();
                if (selectedoption == "population" || selectedoption == "surfacewater" || selectedoption == "diameter")
                {
                    optionSelected = true;
                }

            } while (string.IsNullOrWhiteSpace(selectedoption) || optionSelected == false);
            return selectedoption;
        }

        internal void PrintSelectedStats(string option)
        {
            
            switch (option)
            {
                case "population":
                    var selection = _planets.Select(item => new { item.population, item.name });//fel har inte comparable
                    
                    var max = selection.FirstOrDefault();
                    var min = selection.LastOrDefault();

                    string selectedstring = ($"Max population is:{max.population}({max.name})\n Min population is: {min.population} ({min.name})");
                    Console.WriteLine(selectedstring);
                    break;
                
                 
            }
        }
    }
                    
                 
    public static class StringFormatMarginExtentsions
    {

        public static string Marginized(this string stringToFormat, int margin)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(stringToFormat);
            int stepsmissingtomargin = margin - stringToFormat.Count();
            for (int i = 0; i < stepsmissingtomargin; i++)
            {
                builder.Append(" ");
            }

            return builder.ToString();

        }
    }
}

