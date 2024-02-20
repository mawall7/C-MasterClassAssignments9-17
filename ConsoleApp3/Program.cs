
using StarWarsPlanetsStats;
using UltimateCSharpMasterClass;

string baseadress = "https://swapi.dev";
string requestUri = "api/planets";

//IApiReader reader = new ApiReader();
//string data = await reader.ReadAsync(baseadress, requestUri);
//Console.ReadKey();
PlanetStatsApp app = new PlanetStatsApp(
    new PlanetsRepository(
        new PlanetsStatsReader(
        new ApiReader(),
        baseadress,
        requestUri
    )));

app.Run();
Console.ReadKey();