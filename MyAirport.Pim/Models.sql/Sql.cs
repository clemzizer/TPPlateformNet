using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAirport.Pim.Entities;

namespace MyAirport.Pim.Models
{
    public class Sql : AbstractDefinition
    {

        //string CodeIata:"18536;Drop table BAGAGE"; ok si on utilisa @CodeIata dans la commande
        //PAS DE CONCAT PLS +...+ JAMAIS où 0 
        //"SELECT b.ID_BAGAGE, b.CODE_IATA, b.COMPAGNIE, b.LIGNE, b.DATE_CREATION, b.ESCALE, b.CLASSE, b.CONTINUATION, cast(iif(bp.PARTICULARITE is null, 0, 1) as bit) as 'RUSH' FROM BAGAGE b " + "…";
        // si jointure null => renvoi 0 sinon 1 mais ce sont des int on cast donc pour convertir en booleen

        string strCnx = ConfigurationManager.ConnectionStrings["MyAirport.Pim.Settings.DbConnect"].ConnectionString;
        string commandGetBagageId = "SELECT b.ID_BAGAGE, b.CODE_IATA, b.COMPAGNIE, b.LIGNE, b.DATE_CREATION, b.ESCALE, b.CLASSE, b.CONTINUATION"
            + ", cast(iif(bp.ID_PARTICULARITE is null, 0, 1) as bit) as 'RUSH'"
            + " FROM BAGAGE b left outer join BAGAGE_A_POUR_PARTICULARITE bp on bp.ID_BAGAGE=b.ID_BAGAGE and bp.ID_PARTICULARITE= 15 WHERE b.ID_BAGAGE=@id";

        string commandGetBagageIata = "SELECT b.ID_BAGAGE, b.CODE_IATA, b.COMPAGNIE, b.LIGNE, b.DATE_CREATION, b.ESCALE, b.CLASSE, b.CONTINUATION"
          + ", cast(iif(bp.ID_PARTICULARITE is null, 0, 1) as bit) as 'RUSH'"
          + " FROM BAGAGE b left outer join BAGAGE_A_POUR_PARTICULARITE bp on bp.ID_BAGAGE=b.ID_BAGAGE and bp.ID_PARTICULARITE= 15 WHERE b.CODE_IATA=@code_iata";


        public override BagageDefinition GetBagage(int idBagage)
        {
            BagageDefinition bagRes = null;
            using (SqlConnection cnx = new SqlConnection(strCnx))
            {
                SqlCommand cmd = new SqlCommand(commandGetBagageIata, cnx);
                cmd.Parameters.AddWithValue("@id", idBagage);
                cnx.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                //Implémenter ici le code de récupération et de convertion
                if (sdr.Read()) //return 1 ou 0 à chaque ligne si ca a marché
                {
                    bagRes = new BagageDefinition()
                    {
                        IdBagage = sdr.GetInt32(sdr.GetOrdinal("ID_BAGAGE")),
                        CodeIata = sdr.GetString(sdr.GetOrdinal("CODE_IATA")),
                        EnContinuation = sdr.GetBoolean(sdr.GetOrdinal("CONTINUATION")),                 
                    };

                }
            }
            return bagRes;
        } 

        public override List<BagageDefinition> GetBagage(string codeIataBagage)
        {
            List<BagageDefinition> bagsRes = new List<BagageDefinition>();
            using (SqlConnection cnx = new SqlConnection(strCnx))
            {
                SqlCommand cmd = new SqlCommand(commandGetBagageIata, cnx);
                cmd.Parameters.AddWithValue("@code_iata", codeIataBagage);
                cnx.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                //Implémenter ici le code de récupération et de convertion
                while (sdr.Read()) //return 1 ou 0 à chaque ligne si ca a marché
                {
                    BagageDefinition bagRes = new BagageDefinition()
                    {
                        IdBagage = sdr.GetInt32(sdr.GetOrdinal("ID_BAGAGE")),
                        CodeIata = sdr.GetString(sdr.GetOrdinal("CODE_IATA")),
                        EnContinuation =( sdr.GetString(sdr.GetOrdinal("CONTINUATION"))=="Y"),
                        Compagnie = sdr.GetString(sdr.GetOrdinal("COMPAGNIE")),
                        Ligne = sdr.GetString(sdr.GetOrdinal("LIGNE")),
                        DateVol = sdr.GetDateTime(sdr.GetOrdinal("DATE_CREATION")),
                        Itineraire = sdr.GetString(sdr.GetOrdinal("ESCALE")),
                        //Prioritaire = sdr.GetBoolean(sdr.GetOrdinal("")),
                        Rush = sdr.GetBoolean(sdr.GetOrdinal("RUSH"))
                    };
                    bagsRes.Add(bagRes);

                }
            }
            return bagsRes;
        }
    }
}
