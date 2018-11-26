using MyAirport.Pim.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Pim.Models
{
    public static class Factory
    {
        private static AbstractDefinition singleton = null; // on accède à la classe par cette propriété statique ce qui permet de ne pas définir la classe comme statique
        public static AbstractDefinition Model
        {
            get
            {
                if (singleton == null)
                {
                    switch (ConfigurationManager.AppSettings["Factory"])
                    {
                        case "Sql":
                            singleton = new MyAirport.Pim.Models.Sql();
                            break;
                        case "Natif":
                            singleton = new MyAirport.Pim.Models.Natif();
                            break;
                        default:
                            singleton = new MyAirport.Pim.Models.Natif();
                            break;
                    }
                }
                return singleton;
            }
        }
    }

}
