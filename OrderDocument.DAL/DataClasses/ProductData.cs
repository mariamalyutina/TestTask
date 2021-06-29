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
    public class ProductData
    {
        public string ConnectionString { get; set; }
        public ProductData()
        {
            ConnectionString = null;
        }

        public ProductData(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<ProductDTO> GetProducts()
        {
            List<ProductDTO> productList = new List<ProductDTO>();
            string query = "exec dbo.Product_SelectAll";
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                productList = dbConnection.Query<ProductDTO>(query).AsList<ProductDTO>();
            }

            return productList;
        }

        public ProductDTO GetProductById(int id)
        {
            ProductDTO product = new ProductDTO();
            string query = "exec dbo.Product_SelectByID @id";
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                product = dbConnection.Query<ProductDTO>(query, new { id }).Single<ProductDTO>();
            }

            return product;
        }

        public void AddProduct(ProductDTO product)
        {

            string query;
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                query = "exec dbo.Product_Insert @Name, @StockNumber, @MeasureUnitID, @VatRate";
                dbConnection.Query<ProductDTO>(query, new
                {
                    product.Name,
                    product.StockNumber,
                    product.MeasureUnitID,
                    product.VatRate
                });
            }
        }
    }
}
