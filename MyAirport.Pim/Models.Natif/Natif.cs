using System;
using System.Collections.Generic;

/// <summary>
/// Model created to test our code. Never implemented
/// Runs if App.config has a string saying model is natif or if it is not configured (default choice in Models.Factory)
/// </summary>
namespace MyAirport.Pim.Models
{
    public class Natif : AbstractDefinition
    {
        public override Entities.BagageDefinition GetBagage(int idBagage)
        {
            throw new NotImplementedException();
        }

        public override List<Entities.BagageDefinition> GetBagage(string codeIataBagage)
        {
            throw new NotImplementedException();
        }
    }
}
