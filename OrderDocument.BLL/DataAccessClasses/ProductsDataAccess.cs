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
    public class ProductsDataAccess : AbstractDataAccess
    {
        private ProductData _productsData;

        public ProductsDataAccess()
        {
            _productsData = new ProductData(ConnectionString);
        }

        public List<ProductModel> GetAllProducts()
        {
            List<ProductDTO> productDTOs = _productsData.GetProducts();
            List<ProductModel> productModels = MapperDTOToModel.MapProductDTOToProductModel(productDTOs);
            return productModels;
        }

        public ProductModel GetProductByID(int id)
        {
            List<ProductDTO> productDTOs = new List<ProductDTO>();
            productDTOs.Add(_productsData.GetProductById(id));
            List<ProductModel> productsModels = MapperDTOToModel.MapProductDTOToProductModel(productDTOs);
            return productsModels[0];
        }

        public void AddNewProduct(ProductModel productModel)
        {
            ProductDTO productDTO = MapperModelToDTO.MapProductModelToProductDTO(productModel);
            _productsData.AddProduct(productDTO);
        }
    }
}
