using AutoMapper;
using OrderDocument.BLL.Models;
using OrderDocument.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDocument.BLL.Mappers
{
    public class MapsModelToDTO
    {
        public ProductDTO MapProductModelToProductDTO(ProductModel productModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProductModel, ProductDTO>());
            Mapper mapper = new Mapper(config);
            ProductDTO productDTO = mapper.Map<ProductDTO>(productModel);
            return productDTO;
        }

        public ProviderDTO MapProviderModelToProviderDTO(ProviderModel providerModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProviderModel, ProviderDTO>());
            Mapper mapper = new Mapper(config);
            ProviderDTO providerDTO = mapper.Map<ProviderDTO>(providerModel);
            return providerDTO;
        }

        public SupplyContractDTO MapSupplyContractModelToSupplyContractDTO(SupplyContractModel supplyContractModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<SupplyContractModel, SupplyContractDTO>());
            Mapper mapper = new Mapper(config);
            SupplyContractDTO supplyContractDTO = mapper.Map<SupplyContractDTO>(supplyContractModel);
            return supplyContractDTO;
        }

        public OrderDocumentDTO MapOrderDocumentModelToOrderDocumentDTO(OrderDocumentModel orderDocumentModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<OrderDocumentModel, OrderDocumentDTO>());
            Mapper mapper = new Mapper(config);
            OrderDocumentDTO orederDocumentDTO = mapper.Map<OrderDocumentDTO>(orderDocumentModel);
            return orederDocumentDTO;
        }
    }
}
