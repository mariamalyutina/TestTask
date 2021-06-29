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
    public class StorageDataAccess : AbstractDataAccess
    {
        private StorageData _storageData;

        public StorageDataAccess()
        {
            _storageData = new StorageData(ConnectionString);
        }

        public List<StorageModel> GetAllStorages()
        {
            List<StorageDTO> storageDTOs = _storageData.GetStorages();
            List<StorageModel> storageModels = MapperDTOToModel.MapStorageDTOToStorageModel(storageDTOs);
            return storageModels;
        }

        public StorageModel GetStorageByID(int id)
        {
            List<StorageDTO> storageDTOs = new List<StorageDTO>();
            storageDTOs.Add(_storageData.GetStorageById(id));
            List<StorageModel> storageModels = MapperDTOToModel.MapStorageDTOToStorageModel(storageDTOs);
            return storageModels[0];
        }
    }
}
