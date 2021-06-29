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
    public class SupplyContractDataAccess : AbstractDataAccess
    {
        private SupplyContractData _supplyContractData;

        public SupplyContractDataAccess()
        {
            _supplyContractData = new SupplyContractData(ConnectionString);
        }

        public List<SupplyContractModel> GetSupplyContractsByProviderID(int id)
        {
            List<SupplyContractDTO> supplyContractDTOs = _supplyContractData.GetByProviderId(id);
            List<SupplyContractModel> supplyContractModels = MapperDTOToModel.MapSupplyContractDTOToSupplyContractModel(supplyContractDTOs);
            return supplyContractModels;
        }

        public void AddNewSupplyContract(SupplyContractModel supplyContractModel)
        {
            SupplyContractDTO supplyContractDTO = MapperModelToDTO.MapSupplyContractModelToSupplyContractDTO(supplyContractModel);
            _supplyContractData.AddSupplyContract(supplyContractDTO);
        }
    }
}
