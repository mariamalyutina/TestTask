using OrderDocument.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDocument.DAL.DTOs
{
    public class StorageData
    {
        public string ConnectionString { get; set; }
        public StorageData()
        {
            ConnectionString = null;
        }

        public StorageData(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<StorageDTO> GetStorages()
        {
            List<StorageDTO> storageList = new List<StorageDTO>();
            string query = "exec dbo.Storage_SelectAll";
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                storageList = dbConnection.Query<StorageDTO>(query).AsList<StorageDTO>();
            }

            return storageList;
        }

        public StorageDTO GetStorageById(int id)
        {
            StorageDTO storage = new StorageDTO();
            string query = "exec dbo.Storage_SelectById @id";
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                storage = dbConnection.Query<StorageDTO>(query, new { id }).Single<StorageDTO>();
            }

            return storage;
        }
    }
}
