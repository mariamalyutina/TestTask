using OrderDocument.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDocument.DAL
{
    public class SupplyContractData
    {
        public string ConnectionString { get; set; }
        public SupplyContractData()
        {
            ConnectionString = null;
        }

        public SupplyContractData(string connectionString)
        {
            ConnectionString = connectionString;
        }


        public List<SupplyContractDTO> GetByProviderId(int id)
        {
            List<SupplyContractDTO> supplyContracts = new List<SupplyContractDTO>();
            string query = "exec dbo.SupplyContract_SelectByProviderID @id";
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                supplyContracts = dbConnection.Query<SupplyContractDTO>(query, new { id }).AsList<SupplyContractDTO>();
            }

            return supplyContracts;
        }

        public void AddSupplyContract(SupplyContractDTO supplyContract)
        {
            string query;
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                query = "exec dbo.SupplyContract_Insert @ProviderId, @ContractNumber";
                dbConnection.Query<SupplyContractDTO>(query, new
                {
                    supplyContract.ProviderId,
                    supplyContract.ContractNumber
                });
            }
        }
    }
}
