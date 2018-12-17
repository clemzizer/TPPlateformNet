using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Pim.Entities
{
    /// <summary>
    /// Definition d'un objet baguage
    /// Notre service expose des méthodes qui exploitent des objets BagageDefinition, il convient donc d’indiquer à WCF comment Sérialiser ces objets avec DataContract et DataMember
    /// </summary>
    [DataContract]
    sealed public class BagageDefinition
    {
        [DataMember]
        public int IdBagage { get; set; }           // Identifiant bagage en base de données permet l'identification unique d'un bagage
                                                    //ID_BAGAGE
        [DataMember]
        public string CodeIata { get; set; }        // Numéro du bagage présent sur l'étiquette
        //CODE_IATA

        [DataMember] 
        public string Compagnie { get; set; }       // Code Iata de la compagnie aerienne sur 2 lettres
                                                    //COMPAGNIE
        [DataMember]
        public string Ligne { get; set; }           // Numéro de vol 3 ou 4 digits et parfois une lettre a la fin
                                                    //LIGNE

        [DataMember]
        public DateTime DateVol { get; set; }       // Jour et heure de depart du vol
                                                    // DATE_CREATION

        [DataMember]
        public string Itineraire { get; set; }      // Arrêt ou descend le passager pour ce vol
                                                    //ESCALE

        [DataMember]
        public bool Prioritaire { get; set; }       // Est-ce que le passager est un passager prioritaire?
        //CLASSE => Y= TRUE otherwise NULL

        [DataMember]
        public bool EnContinuation { get; set; }    // Si la destination est différente de l'itineraire, est-ce que le bagage doit être livré au passager au prochain arrêt?
        //CONTINUATION

        [DataMember]
        public bool Rush { get; set; }              // Bagage sans passager (pour les bagages ayant ratés un vol)
        //RUSH
    }
}

