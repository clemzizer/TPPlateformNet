using MyAirport.Pim.Entities;
using System.Collections.Generic;


namespace MyAirport.Pim.Models
{
    /// <summary>
    /// Cette classe est exposée par la Factory via l’utilisation d’un pattern singleton permettant au client un accès simple aux données sans avoir à gérer le cycle de vie de l’instance Abstraite.
    /// L’utilisation d’une Factory nous permet de faire abstraction du modèle de données physique.
    /// La Factory a en charge de créer le modèle physique (indiquer dans le fichier de configuration de l’application) et de l’exposer via une classe abstraite.
    /// 
    /// 
    /// Toutes les implémentations liées à un modèle physique de données devront donc dériver de cette classe abstraite
    /// 
    /// 
    /// </summary>
    public abstract class AbstractDefinition
    {
        public abstract BagageDefinition GetBagage(int idBagage);
        public abstract List<BagageDefinition> GetBagage(string codeIataBagage);
    }
}
