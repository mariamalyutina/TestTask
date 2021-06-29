using OrderDocument.BLL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDocument.BLL.DataAccessClasses
{
    public abstract class AbstractDataAccess
    {
        public string ConnectionString = @"Server=localhost;Database=TestTask;Trusted_Connection=True;";
        public MapsDTOtoModel MapperDTOToModel = new MapsDTOtoModel();
        public MapsModelToDTO MapperModelToDTO = new MapsModelToDTO();
    }
}
