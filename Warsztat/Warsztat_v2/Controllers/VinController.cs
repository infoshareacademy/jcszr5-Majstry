using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Warsztat_v2.Controllers;

public class VinController : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index(string? vin)
    {
        var client = new HttpClient();
        var response = await client.GetAsync($"https://vpic.nhtsa.dot.gov/api/vehicles/decodevinvalues/{vin}?format=json");
        var vinResponse = await response.Content.ReadFromJsonAsync<VinResponse>();
        return View(vinResponse.Results[0]);
    }
}

public class Result
{
    public string BodyClass { get; set; }
    public string Doors { get; set; }
    public string EngineCylinders { get; set; }
    public string EngineHP { get; set; }
    public string EngineKW { get; set; }
    public string EngineModel { get; set; }
    public string FuelTypePrimary { get; set; }
    public string Make { get; set; }
    public string MakeID { get; set; }
    public string Manufacturer { get; set; }
    public string ManufacturerId { get; set; }
    public string Model { get; set; }
    public string ID { get; set; }
    public string ModelYear { get; set; }
    public string PlantCountry { get; set; }
    public string SuggestedVIN { get; set; }
    public string VIN { get; set; }
    public string VehicleType { get; set; }
}
public class VinResponse
{
    public int Count { get; set; }
    public string Message { get; set; }
    public string SearchCriteria { get; set; }
    public Result[] Results { get; set; }
}

