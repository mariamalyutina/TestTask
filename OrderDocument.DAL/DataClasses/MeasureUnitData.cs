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
    public class MeasureUnitData
    {
        public string ConnectionString { get; set; }
        public MeasureUnitData()
        {
            ConnectionString = null;
        }

        public MeasureUnitData(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<MeasureUnitDTO> GetMeasureUnits()
        {
            List<MeasureUnitDTO> measureUnitsList = new List<MeasureUnitDTO>();
            string query = "exec dbo.MeasureUnit_SelectAll";
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                measureUnitsList = dbConnection.Query<MeasureUnitDTO>(query).AsList<MeasureUnitDTO>();
            }

            return measureUnitsList;
        }
    }
}
