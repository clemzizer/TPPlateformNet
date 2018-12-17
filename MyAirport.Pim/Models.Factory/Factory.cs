using System.Configuration;


namespace MyAirport.Pim.Models
{
    /// <summary>
    /// La Factory va nous servir d’intermédiaire pour accéder à notre source de données. 
    /// La Factory a en charge de créer le modèle physique (indiquer dans le fichier de configuration de l’application) et de l’exposer via une classe abstrait
    /// La Factory expose la classe abstraite via l’utilisation d’un pattern singleton permettant au client un accès simple aux données sans avoir à gérer le cycle de vie de l’instance Abstraite.
    /// </summary>
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
