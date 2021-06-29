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
    public class ProviderData
    {
        public string ConnectionString { get; set; }
        public ProviderData()
        {
            ConnectionString = null;
        }

        public ProviderData(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<ProviderDTO> GetProviders()
        {
            List<ProviderDTO> providerList = new List<ProviderDTO>();
            string query = "exec dbo.Provider_SelectAll";
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                providerList = dbConnection.Query<ProviderDTO>(query).AsList<ProviderDTO>();
            }

            return providerList;
        }

        public ProviderDTO GetProviderById(int id)
        {
            ProviderDTO provider = new ProviderDTO();
            string query = "exec dbo.Provider_SelectById @id";
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                provider = dbConnection.Query<ProviderDTO>(query, new { id }).Single<ProviderDTO>();
            }

            return provider;
        }

        public void AddProvider(ProviderDTO provider)
        {

            string query;
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                query = "exec dbo.Provider_Insert @Name";
                dbConnection.Query<ProviderDTO>(query, new
                {
                    provider.Name
                });
            }
        }
    }
}
