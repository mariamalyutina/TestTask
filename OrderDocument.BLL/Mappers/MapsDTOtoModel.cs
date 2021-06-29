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
    public class MapsDTOtoModel
    {
       
        public List<ProductModel> MapProductDTOToProductModel(List<ProductDTO> productDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProductDTO, ProductModel>());
            Mapper mapper = new Mapper(config);
            List<ProductModel> productModels = mapper.Map<List<ProductModel>>(productDTO);
            return productModels;
        }

        public List<ProviderModel> MapProviderDTOToProviderModel(List<ProviderDTO> providerDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProviderDTO, ProviderModel>());
            Mapper mapper = new Mapper(config);
            List<ProviderModel> providerModels = mapper.Map<List<ProviderModel>>(providerDTO);
            return providerModels;
        }

        public List<StorageModel> MapStorageDTOToStorageModel(List<StorageDTO> storageDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<StorageDTO, StorageModel>());
            Mapper mapper = new Mapper(config);
            List<StorageModel> storageModels = mapper.Map<List<StorageModel>>(storageDTO);
            return storageModels;
        }

        public List<SupplyContractModel> MapSupplyContractDTOToSupplyContractModel(List<SupplyContractDTO> supplyContractDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<SupplyContractDTO, SupplyContractModel>());
            Mapper mapper = new Mapper(config);
            List<SupplyContractModel> supplyContractModels = mapper.Map<List<SupplyContractModel>>(supplyContractDTO);
            return supplyContractModels;
        }

        public List<MeasureUnitModel> MapMeasureUnitDTOToMeasureUnitModel(List<MeasureUnitDTO> measureUnitDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<MeasureUnitDTO, MeasureUnitModel>());
            Mapper mapper = new Mapper(config);
            List<MeasureUnitModel> measureUnitModels = mapper.Map<List<MeasureUnitModel>>(measureUnitDTO);
            return measureUnitModels;
        }

        public List<OrderDocumentBaseModel> MapOrderDocumentDTOToOrderDocumentBaseModel(List<OrderDocumentDTO> orderDocumentDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<OrderDocumentDTO, OrderDocumentBaseModel>());
            Mapper mapper = new Mapper(config);
            List<OrderDocumentBaseModel> orderDocumentBaseModels = mapper.Map<List<OrderDocumentBaseModel>>(orderDocumentDTO);
            return orderDocumentBaseModels;
        }

        public List<OrderDocumentModel> MapOrderDocumentDTOToOrderDocumentModel(List<OrderDocumentDTO> orderDocumentDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<OrderDocumentDTO, OrderDocumentModel>());
            Mapper mapper = new Mapper(config);
            List<OrderDocumentModel> orderDocumentModels = mapper.Map<List<OrderDocumentModel>>(orderDocumentDTO);
            return orderDocumentModels;
        }

        public List<ProductInOrderDocModel> MapProductInOrderDocDTOToProductInOrderDocModel(List<ProductInOrderDocDTO> productInOrderDocDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProductInOrderDocDTO, ProductInOrderDocModel>());
            Mapper mapper = new Mapper(config);
            List<ProductInOrderDocModel> productInOrderDocModels = mapper.Map<List<ProductInOrderDocModel>>(productInOrderDocDTO);
            return productInOrderDocModels;
        }
    }
}
