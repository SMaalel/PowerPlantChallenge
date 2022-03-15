using Microsoft.AspNetCore.Mvc;
using PowerPlantChallenge.Models;
using System;

namespace PowerPlantChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TreatmentController : ControllerBase
    {
        Treatment ctrlTrait = new Treatment();
        [Route("api/productionplan")]
        [HttpPost]
        public JsonResponse DoTreatment(JsonPayload JsonBody)
        {
            JsonResponse lres = new JsonResponse();
            try
            {
                decimal cost;
                //appel treatment
                foreach (Powerplants powerPlant in JsonBody.powerplants)
                {
                    //calcul cost
                    cost = ctrlTrait.CalculCost(powerPlant, JsonBody.Fuels);
                }


                return lres;
            }
            catch (Exception ex)
            {
                return lres;
            }

        }

    }
}
