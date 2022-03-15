using PowerPlantChallenge.Models;
using System;

namespace PowerPlantChallenge
{
    public class Treatment
    {
        public Treatment()
        {

        }


        public decimal CalculCost(Powerplants powerPlant, Fuels fuels)
        {
            decimal cost = 0;
            try
            {
                if (powerPlant.type == "gasfired")
                {
                    cost = fuels.gas / powerPlant.efficiency;
                    return cost;
                }
                else if (powerPlant.type == "turbojet")
                {
                    cost = fuels.kerosine / powerPlant.efficiency;
                    return cost;
                }
                else //if (powerPlant.type == "windturbine")
                {
                    return cost;
                }

            }
            catch (Exception ex)
            {
                return cost;
            }
        }
    }
}
