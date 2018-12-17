using MyAirport.Pim.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace MyAirport.Pim.Service
{
    /// <summary>
    /// This class implements the behaviour of our service
    /// </summary>
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ServicePim : IServicePim
    {
        public int Nbinstance=0;
        private int NbAppel = 0;

        public ServicePim()
        {
            Nbinstance++;
        }
        public int CreateBagage(BagageDefinition bag)
        {
            throw new NotImplementedException();
        }
        public List<BagageDefinition> GetBagageByCodeIata(string codeIata)
        {
            return MyAirport.Pim.Models.Factory.Model.GetBagage(codeIata);

        }
        public BagageDefinition GetBagageById(int idBagage)
        {
            throw new NotImplementedException();
        }
    }
}
