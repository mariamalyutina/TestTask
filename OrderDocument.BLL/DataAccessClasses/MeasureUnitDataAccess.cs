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
    public class MeasureUnitDataAccess : AbstractDataAccess
    {
        private MeasureUnitData _measureUnitData;

        public MeasureUnitDataAccess()
        {
            _measureUnitData = new MeasureUnitData(ConnectionString);
        }

        public List<MeasureUnitModel> GetAllMeasureUnits()
        {
            List<MeasureUnitDTO> measureUnitDTOs = _measureUnitData.GetMeasureUnits();
            List<MeasureUnitModel> measureUnitModels = MapperDTOToModel.MapMeasureUnitDTOToMeasureUnitModel(measureUnitDTOs);
            return measureUnitModels;
        }
    }
}
