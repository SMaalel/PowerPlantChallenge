using System.Collections.Generic;

namespace PowerPlantChallenge.Models
{
    public class JsonResponse
    {
        public JsonResponse()
        {
            name = string.Empty;
            p = 0;
        }
        public string name { get; set; }
        public int p { get; set; }
    }

    public class JsonPayload
    {
        public JsonPayload()
        {
            Load = 0;
            Fuels = new Fuels();
            powerplants = new List<Powerplants>();
        }
        public int Load { get; set; }
        public Fuels Fuels { get; set; }
        public List<Powerplants> powerplants { get; set; }

    }
    public class Fuels
    {
        public Fuels()
        {
            gas = 0;
            kerosine = 0;
            co2 = 0;
            wind = 0;
        }
        public decimal gas { get; set; }
        public decimal kerosine { get; set; }
        public int co2 { get; set; }
        public int wind { get; set; }
    }
    public class Powerplants
    {
        public Powerplants()
        {
            name = string.Empty;
            type = string.Empty;
            efficiency = 0;
            pmin = 0;
            pmax = 0;
        }
        public string name { get; set; }
        public string type { get; set; }
        public decimal efficiency { get; set; }
        public int pmin { get; set; }
        public int pmax { get; set; }
    }
}
