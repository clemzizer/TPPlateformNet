using MyAirport.Pim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyAirport.Pim.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServicePim : IServicePim
    {
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
