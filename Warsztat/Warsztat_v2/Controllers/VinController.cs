using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rotativa.MVC;

namespace Warsztat_v2.Controllers;

    public class VinController : Controller
    {
        /*private readonly ICompositeViewEngine _compositeViewEngine;

        public VinController(ICompositeViewEngine compositeViewEngine)
        {
            _compositeViewEngine = compositeViewEngine;
        }*/
       
        
        [HttpGet]
        public async Task<ActionResult> Index(string? vin)
        {
            var result = await Result(vin);
            return View(result);
        }

        private static async Task<Result> Result(string? vin)
        {
            var client = new HttpClient();
            var response =
                await client.GetAsync($"https://vpic.nhtsa.dot.gov/api/vehicles/decodevinvalues/{vin}?format=json");
            var vinResponse = await response.Content.ReadFromJsonAsync<VinResponse>();
            var result = vinResponse.Results[0];
            return result;
        }

        public FileStreamResult VinDownload(string? vin)
        {
            string data = JsonConvert.SerializeObject(Result(vin).Result);
            data = data.Replace("{", "")
                .Replace("}", "")
                .Replace("\""," ")
                .Replace(",", "\n");
            var byteArray = Encoding.ASCII.GetBytes(data);
            var stream = new MemoryStream(byteArray);
            return File(stream, "text/plain", "vin.txt");
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

