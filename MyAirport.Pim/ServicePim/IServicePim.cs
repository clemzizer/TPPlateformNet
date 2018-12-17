using MyAirport.Pim.Entities;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;


namespace MyAirport.Pim.Service
{
    /// <summary>
    /// This interface allows us to define what will be exposed by the service
    /// (Les attributs OperationContract sont utilisés par WCF pour connaitre les méthodes qui devront être exposées par le service. L’attribut ServiceContract permet à WCF de savoir que cette interface expose des méthodes de service. L’ensemble des classes nécessaires à WCF sont regroupées dans l’assembly System.ServiceModel.)
    /// </summary>
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServicePim
    {
        [OperationContract]
        BagageDefinition GetBagageById(int idBagage);
        [OperationContract]
        List<BagageDefinition> GetBagageByCodeIata(string codeIata);
        [OperationContract]
        int CreateBagage(BagageDefinition bag);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ServicePim.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
