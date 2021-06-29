using OrderDocument.DAL.DTOs;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace OrderDocument.DAL
{
    public class OrderDocumentData
    {
        public string ConnectionString { get; set; }
        public OrderDocumentData()
        {
            ConnectionString = null;
        }

        public OrderDocumentData(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<OrderDocumentDTO> GetOrderDocuments()
        {
            List<OrderDocumentDTO> orderDocumentsList = new List<OrderDocumentDTO>();
            string query = "exec dbo.OrderDocument_SelectAll";
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                orderDocumentsList = dbConnection.Query<OrderDocumentDTO>(query).AsList<OrderDocumentDTO>();
            }
            return orderDocumentsList;
        }

        public OrderDocumentDTO GetOrderDocumentById(int id)
        {
            OrderDocumentDTO orderDocument = new OrderDocumentDTO();
            string query = "exec dbo.OrderDocument_SelectByID @id";
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                orderDocument = dbConnection.Query<OrderDocumentDTO>(query, new { id }).Single<OrderDocumentDTO>();
            }

            return orderDocument;
        }

        public void AddOrderDocument(OrderDocumentDTO orderDocument)
        {

            string query;
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                query = "exec dbo.OrderDocument_Insert @Date, @SupplyContractID, @StorageID";
                dbConnection.Query<ProductDTO>(query, new
                {
                    orderDocument.Date,
                    orderDocument.SupplyContractID,
                    orderDocument.StorageID
                });
            }
        }

        public List<ProductInOrderDocDTO> GetProductsOfOrderDocument(int id)
        {
            List<ProductInOrderDocDTO> orderDocumentProductsList = new List<ProductInOrderDocDTO>();
            string query = "exec dbo.OrderDocument_SelectAllProducts @id";
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                orderDocumentProductsList = dbConnection.Query<ProductInOrderDocDTO>(query, new { id }).AsList<ProductInOrderDocDTO>();
            }
            return orderDocumentProductsList;
        }

        public void AddProductToOrderDocument(int orderDocID, int productID, float amount, float price)
        {
            string query;
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                query = "exec dbo.OrderDocument_Product_Insert @orderDocID, @productID, @amount, @price";
                dbConnection.Query(query, new { orderDocID, productID, amount, price });
            }
        }

        public void DeleteProductFromOrderDocument(int orderDocID, int productID)
        {
            string query;
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                query = "exec dbo.OrderDocument_Product_Delete @orderDocID, @productID";
                dbConnection.Query(query, new { orderDocID, productID});
            }
        }

        public void UpdateProductInfoInOrderDocument(int orderDocID, int productID, float amount, float price)
        {
            string query;
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                query = "exec dbo.OrderDocument_Product_Update @orderDocID, @productID, @amount, @price";
                dbConnection.Query(query, new { orderDocID, productID, amount, price });
            }
        }

        public void UpdateOrderDocument(OrderDocumentDTO orderDocument)
        {
            string query;
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                query = "exec dbo.OrderDocument_Update @Id, @Date, @SupplyContractID, @StorageID";
                dbConnection.Query<ProductDTO>(query, new
                {
                    orderDocument.Id,
                    orderDocument.Date,
                    orderDocument.SupplyContractID,
                    orderDocument.StorageID
                });
            }
        }

        public void DeleteOrderDocument(int id)
        {
            string query;
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                query = "exec dbo.OrderDocument_Delete @Id";
                dbConnection.Query(query, new { id });
            }
        }
    }
}
