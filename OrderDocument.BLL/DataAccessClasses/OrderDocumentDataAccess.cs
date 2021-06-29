using OrderDocument.BLL.Models;
using OrderDocument.DAL;
using OrderDocument.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDocument.BLL.DataAccessClasses
{
    public class OrderDocumentDataAccess : AbstractDataAccess
    {
        private OrderDocumentData _orderDocumentData;

        public OrderDocumentDataAccess()
        {
            _orderDocumentData = new OrderDocumentData(ConnectionString);
        }

        public List<OrderDocumentBaseModel> GetAllOrderDocuments()
        {
            List<OrderDocumentDTO> oredrDocumentDTOs = _orderDocumentData.GetOrderDocuments();
            List<OrderDocumentBaseModel> oredrDocumentBaseModels = MapperDTOToModel.MapOrderDocumentDTOToOrderDocumentBaseModel(oredrDocumentDTOs);
            return oredrDocumentBaseModels;
        }

        public OrderDocumentModel GetOrderDocumentByID(int id)
        {
            List<OrderDocumentDTO> oredrDocumentDTOs = new List<OrderDocumentDTO>();
            oredrDocumentDTOs.Add(_orderDocumentData.GetOrderDocumentById(id));
            List<OrderDocumentModel> orderDocumentModels = MapperDTOToModel.MapOrderDocumentDTOToOrderDocumentModel(oredrDocumentDTOs);
            return orderDocumentModels[0];
        }

        public void AddNewOrderDocument(OrderDocumentModel orderDocumentrModel)
        {
            OrderDocumentDTO oredrDocumentDTO = MapperModelToDTO.MapOrderDocumentModelToOrderDocumentDTO(orderDocumentrModel);
            _orderDocumentData.AddOrderDocument(oredrDocumentDTO);
        }

        public List<ProductInOrderDocModel> GetProductsOfOrderDocument(int id)
        {
            List<ProductInOrderDocDTO> productInOrderDocDTOs = _orderDocumentData.GetProductsOfOrderDocument(id);
            List<ProductInOrderDocModel> productInOrderDocModels = MapperDTOToModel.MapProductInOrderDocDTOToProductInOrderDocModel(productInOrderDocDTOs);
            return productInOrderDocModels;
        }

        public void AddProductToOrderDocument(int orderDocID, int productID, float amount, float price)
        {
            _orderDocumentData.AddProductToOrderDocument(orderDocID, productID, amount, price);
        }

        public void DeleteProductFromOrderDocument(int orderDocID, int productID)
        {
            _orderDocumentData.DeleteProductFromOrderDocument(orderDocID, productID);
        }

        public void UpdateProductInfoInOrderDocument(int orderDocID, int productID, float amount, float price)
        {
            _orderDocumentData.UpdateProductInfoInOrderDocument(orderDocID, productID, amount, price);
        }

        public void UpdateOrderDocument(OrderDocumentModel orderDocumentrModel)
        {
            OrderDocumentDTO oredrDocumentDTO = MapperModelToDTO.MapOrderDocumentModelToOrderDocumentDTO(orderDocumentrModel);
            _orderDocumentData.UpdateOrderDocument(oredrDocumentDTO);
        }

        public void DeleteOrderDocument(int id)
        {
            _orderDocumentData.DeleteOrderDocument(id);
        }
    }
}
