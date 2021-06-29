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
    public class ProviderDataAccess : AbstractDataAccess
    {
        private ProviderData _providerData;

        public ProviderDataAccess()
        {
            _providerData = new ProviderData(ConnectionString);
        }

        public List<ProviderModel> GetAllProvidres()
        {
            List<ProviderDTO> providerDTOs = _providerData.GetProviders();
            List<ProviderModel> providerModels = MapperDTOToModel.MapProviderDTOToProviderModel(providerDTOs);
            return providerModels;
        }

        public ProviderModel GetProviderByID(int id)
        {
            List<ProviderDTO> providerDTOs = new List<ProviderDTO>();
            providerDTOs.Add(_providerData.GetProviderById(id));
            List<ProviderModel> providerModels = MapperDTOToModel.MapProviderDTOToProviderModel(providerDTOs);
            return providerModels[0];
        }

        public void AddNewProvider(ProviderModel providerModel)
        {
            ProviderDTO providerDTO = MapperModelToDTO.MapProviderModelToProviderDTO(providerModel);
            _providerData.AddProvider(providerDTO);
        }

       
    }
}
